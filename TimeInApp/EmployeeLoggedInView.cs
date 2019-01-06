using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeInApp.Models;
using System.Net.Cache;
using System.IO;
using System.Net;
using System.Web.Script.Serialization;

namespace TimeInApp
{
    public partial class EmployeeLoggedInView : Form
    {
        Timer clock = new Timer();

        public EmployeeLoggedInView()
        {
            InitializeComponent();
        }

        /*
         * http://localhost:49909 - TimeInEmployee service
         * http://localhost:55799 - TImeInLogin service
         * 
         */

        private void EmployeeLoggedInView_Load(object sender, EventArgs e)
        {
            clock.Interval = 1000;
            clock.Tick += new EventHandler(this.ClockTick);

            clock.Start();
            bool hasClockedIn = CheckIfEmployeeClockedIn();
            GenerateEmployeeReport(DateTime.Now.Date);
            InitializeActivityDropDown(hasClockedIn);
        }

        private void InitializeActivityDropDown(bool hasClockedIn)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest
                .Create("http://localhost:49909/api/TimeInEmployee/GetEmployeeClockInChoices");

            HttpWebResponse response = null;
            string responseValue = string.Empty;

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
                            List<ActivityQueryModel> verifyResult = new JavaScriptSerializer().Deserialize<List<ActivityQueryModel>>(responseValue);

                            List<ActivityModel> activityOption = verifyResult
                                .Select(x => new ActivityModel {
                                    ActivityId = x.ActivityId,
                                    ActivityNm = x.ActivityNm
                                }).ToList();

                            bindingSource1.DataSource = activityOption;
                            ClockInActivity.DataSource = bindingSource1.DataSource;
                            ClockInActivity.DisplayMember = "ActivityNm";
                            ClockInActivity.ValueMember = "ActivityId";
                            ClockInActivity.SelectedItem = null;
                            ClockInActivity.SelectedText = "-- Select --";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                responseValue = "Error occured while processing your request";
                MessageBox.Show(responseValue, "Error", MessageBoxButtons.OK);
            }
            finally
            {
                if (response != null)
                {
                    ((IDisposable)response).Dispose();
                }
            }
        }

        private void GenerateEmployeeReport(DateTime reportDate)
        {
            if (reportDate == null)
            {
                MessageBox.Show("No report date selected.", "Error", MessageBoxButtons.OK);
            }
            else
            {
                ReportQueryModel model = new ReportQueryModel()
                {
                    UserKey = UserSessionModel.UserKey,
                    ReportDate = reportDate.ToString()
                };

                string modelJson = new JavaScriptSerializer().Serialize(model);

                string responseValue = string.Empty;
                HttpWebRequest request = (HttpWebRequest)WebRequest
                    .Create("http://localhost:49909/api/TimeInEmployee/GenerateEmployeeMonthyReport");
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
                                GeneratedReportModel verifyResult = new JavaScriptSerializer().Deserialize<GeneratedReportModel>(responseValue);

                                if (verifyResult.QueryStatus == "Report generated.")
                                {
                                    dataGridView1.Visible = true;
                                    DataGridMessage.Visible = false;
                                    DataTable table = ConvertListToDataTable(verifyResult.TimeList);
                                    dataGridView1.DataSource = table;
                                    dataGridView1.Columns[0].Width = 100;
                                    dataGridView1.Columns[1].Width = 150;
                                    dataGridView1.Columns[2].Width = 150;
                                }
                                else if(verifyResult.QueryStatus == "Invalid report date selected.")
                                {
                                    throw new Exception("Invalid report date selected.");
                                }
                                else if(verifyResult.QueryStatus == "No data available.")
                                {
                                    DataGridMessage.Visible = true;
                                    DataGridMessage.Text = verifyResult.QueryStatus;
                                    dataGridView1.Visible = false;
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
                    if (ex.Message == "Invalid user" || ex.Message == "Invalid report date selected.")
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

        static DataTable ConvertListToDataTable(List<TimeInTimeOut> list)
        {
            // New table.
            DataTable table = new DataTable();

            table.Columns.Add("Activity");
            table.Columns.Add("TimeIn");
            table.Columns.Add("TimeOut");


            // Add rows.
            foreach (var array in list)
            {
                DataRow row = table.NewRow();
                row["Activity"] = array.ActivityName;
                row["TimeIn"] = array.TimeInDateTime;
                row["TimeOut"] = array.TImeOutDateTime;

                table.Rows.Add(row);
            }

            return table;
        }

        private bool CheckIfEmployeeClockedIn()
        {
            bool hasClockedIn = false;
            VerifyUserClockInModel model = new VerifyUserClockInModel
            {
                UserKey = UserSessionModel.UserKey
            };

            string modelJson = new JavaScriptSerializer().Serialize(model);

            string responseValue = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest
                .Create("http://localhost:55799/api/Login/VerifyEmployeeClockIn");
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
                            VerifyClockInResultModel verifyResult = new JavaScriptSerializer().Deserialize<VerifyClockInResultModel>(responseValue);

                            if (verifyResult.QueryStatus == "Query success.")
                            {
                                ClockIn.Enabled = !verifyResult.ClockedIn;
                                ClockInActivity.Enabled = !verifyResult.ClockedIn;
                                ClockOut.Enabled = verifyResult.ClockedIn;
                                ClockOutActivity.Enabled = verifyResult.ClockedIn;
                                hasClockedIn = verifyResult.ClockedIn;

                                if (verifyResult.ClockedIn)
                                {
                                    ClockOutActivity.Text = verifyResult.ActivityNm;
                                    ClockOutActivityId.Text = verifyResult.ActivityId.ToString();
                                }

                                return hasClockedIn;
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
            return hasClockedIn;
        }

        private void ClockTick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;
            string today = DateTime.Now.Date.ToShortDateString();

            string timeDisplay = string.Empty;

            if (hh < 10)
            {
                timeDisplay += "0" + hh;
            }
            else
            {
                timeDisplay += hh;
            }
            timeDisplay += ":";
            if(mm < 10)
            {
                timeDisplay += "0" + mm;
            }
            else
            {
                timeDisplay += mm;
            }
            timeDisplay += ":";
            if(ss < 10)
            {
                timeDisplay += "0" + ss;
            }
            else
            {
                timeDisplay += ss;
            }

            label1.Text = timeDisplay;
            label3.Text = today;
        }

        private void EmployeeLoggedInView_Closed(object sender, FormClosedEventArgs e)
        {
            new LoginForm().Show();
            this.Dispose();
        }

        private void ClockIn_Click(object sender, EventArgs e)
        {
            try
            {
                ClockInModel clockIn = new ClockInModel()
                {
                    ActivityId = Int32.Parse(ClockInActivity.SelectedValue.ToString()),
                    UserKey = UserSessionModel.UserKey,
                    ClockInDateTime = DateTime.Now.ToString()
                };

                string modelJson = new JavaScriptSerializer().Serialize(clockIn);

                string responseValue = string.Empty;
                HttpWebRequest request = (HttpWebRequest)WebRequest
                    .Create("http://localhost:49909/api/TimeInEmployee/ClockInEmployee");
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
                                DefaultQueryResultModel verifyResult = new JavaScriptSerializer().Deserialize<DefaultQueryResultModel>(responseValue);

                                if (verifyResult.Result == "Employee successfully clocked in.")
                                {
                                    ClockIn.Enabled = false;
                                    ClockInActivity.Enabled = false;
                                    ClockOut.Enabled = true;
                                    ClockOutActivity.Enabled = true;

                                    ClockOutActivity.Text = ClockInActivity.Text;
                                    ClockOutActivityId.Text = ClockInActivity.SelectedValue.ToString();

                                    MessageBox.Show(verifyResult.Result, "Error", MessageBoxButtons.OK);
                                }
                                else if(verifyResult.Result == "Already clocked in for the day.")
                                {
                                    throw new Exception(verifyResult.Result);
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
                    if (ex.Message == "Invalid user" || ex.Message == "Already clocked in for the day.")
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
            catch(Exception ex)
            {
                MessageBox.Show("Select Clock In Activity before clocking in.", "Error", MessageBoxButtons.OK);
            }
        }

        private void ClockOut_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(ClockOutActivity.Text) || string.IsNullOrEmpty(ClockOutActivityId.Text))
            {
                MessageBox.Show("Clock Out Activity is not populated.", "Error", MessageBoxButtons.OK);
            }
            else
            {
                ClockOutModel clockOut = new ClockOutModel()
                {
                    ActivityId = Int32.Parse(ClockOutActivityId.Text),
                    UserKey = UserSessionModel.UserKey,
                    ClockOutDateTime = DateTime.Now.ToString()
                };

                string modelJson = new JavaScriptSerializer().Serialize(clockOut);

                string responseValue = string.Empty;
                HttpWebRequest request = (HttpWebRequest)WebRequest
                    .Create("http://localhost:49909/api/TimeInEmployee/ClockOutEmployee");
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
                                DefaultQueryResultModel verifyResult = new JavaScriptSerializer().Deserialize<DefaultQueryResultModel>(responseValue);

                                if (verifyResult.Result == "Employee successfully clocked out.")
                                {
                                    ClockIn.Enabled = true;
                                    ClockInActivity.Enabled = true;
                                    ClockOut.Enabled = false;
                                    ClockOutActivity.Enabled = false;

                                    ClockOutActivity.Text = string.Empty;
                                    ClockOutActivityId.Text = string.Empty;

                                    MessageBox.Show(verifyResult.Result, "Error", MessageBoxButtons.OK);
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateSelected = dateTimePicker1.Value;
            GenerateEmployeeReport(dateSelected);
        }

        private void UpdatePasswordButton_Click(object sender, EventArgs e)
        {
            new UpdatePasswordForm().Show();
        }
    }
}
