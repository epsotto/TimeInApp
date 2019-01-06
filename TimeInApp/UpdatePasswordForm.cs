using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using TimeInApp.Models;

namespace TimeInApp
{
    public partial class UpdatePasswordForm : Form
    {
        public UpdatePasswordForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string oldPassword = PreviousPassword.Text;
            string newPassword = NewPassword.Text;
            string retypePassword = RetypePassword.Text;

            if(newPassword != retypePassword)
            {
                MessageBox.Show("Passwords don't match.", "Error", MessageBoxButtons.OK);
            }
            else
            {
                UpdatePasswordModel passwordModel = new UpdatePasswordModel()
                {
                    UserKey = UserSessionModel.UserKey,
                    NewPassword = newPassword,
                    PreviousPassword = oldPassword
                };

                string modelJson = new JavaScriptSerializer().Serialize(passwordModel);

                string responseValue = string.Empty;
                HttpWebRequest request = (HttpWebRequest)WebRequest
                    .Create("http://localhost:55799/api/Login/UpdateUserPassword");
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
                                DefaultQueryResultModel updateResult = new JavaScriptSerializer().Deserialize<DefaultQueryResultModel>(responseValue);

                                if (updateResult.Result == "User record updated.")
                                {
                                    MessageBox.Show(updateResult.Result, "Error", MessageBoxButtons.OK);
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

        private void CloseWindowButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
