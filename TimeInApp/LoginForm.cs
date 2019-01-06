using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using TimeInApp.Models;

namespace TimeInApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginRequestModel model = new LoginRequestModel()
            {
                UserName = textBox1.Text,
                Password = textBox2.Text
            };

            if (model.UserName == "admin" && model.Password == "123456")
            {
                new AdminDashboard().Show();
                this.Hide();
            }
            else
            {
                string modelJson = new JavaScriptSerializer().Serialize(model);

                string responseValue = string.Empty;
                HttpWebRequest request = (HttpWebRequest)WebRequest
                    .Create("http://localhost:55799/api/Login/AuthenticateUser");
                request.Method = "POST";
                request.ContentType = "application/json";

                using (StreamWriter sw = new StreamWriter(request.GetRequestStream()))
                {
                    sw.Write(modelJson);
                    sw.Close();
                }

                HttpWebResponse response = null;

                try
                {
                    response = (HttpWebResponse)request.GetResponse();
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        if (responseStream != null)
                        {
                            using (StreamReader reader = new StreamReader(responseStream))
                            {
                                responseValue = reader.ReadToEnd();
                                SuccessAuthModel loginResult = new JavaScriptSerializer().Deserialize<SuccessAuthModel>(responseValue);

                                if (loginResult.QueryStatus == "Password matched.")
                                {
                                    UserSessionModel.UserName = textBox1.Text;
                                    UserSessionModel.UserKey = loginResult.UserKey;
                                    new EmployeeLoggedInView().Show();

                                    textBox1.Text = "";
                                    textBox2.Text = "";
                                    this.Hide();
                                }
                                else
                                {
                                    throw new Exception("Invalid user");
                                }

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    if (ex.Message == "Invalid user")
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                    }
                    else
                    {
                        responseValue = "Error occured while processing your request";
                        MessageBox.Show(responseValue, "Error", MessageBoxButtons.OK);
                    }
                }
                finally
                {
                    if (response != null)
                    {
                        ((IDisposable)response).Dispose();
                    }
                }
            }
        }

        private void LoginForm_Closing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
