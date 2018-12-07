using System;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using System.Text;
using System.IO;

namespace DEATHTOWINDOWSFORMS
{
    public partial class CUBRILOXDDDDDDDDDDDDDDDD : Form
    {
        private string m_CookieValue;

        public CUBRILOXDDDDDDDDDDDDDDDD()
        {
            InitializeComponent();
        }

        private void CatchCookies(HttpWebResponse response)
        {
            try
            {
                m_CookieValue = response.Headers.Get("Set-Cookie");
            }
            catch
            {
                // ODJEBI
            }
        }

        private void AddCookies(HttpWebRequest request)
        {
            request.Headers.Add("Cookie", m_CookieValue);
        }

        public class LoginBody
        {
            public string identification, password;

            public LoginBody(string identification, string password)
            {
                this.identification = identification;
                this.password = password;
            }
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            HttpWebRequest hwr = WebRequest.Create(@"https://commuter-application.herokuapp.com/authentication/login") as HttpWebRequest;
            hwr.Method = "POST";
            string body = JsonConvert.SerializeObject(new LoginBody("username", "password"));
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] bodyStream = encoding.GetBytes(body);
            hwr.ContentType = "application/json";
            hwr.ContentLength = bodyStream.Length;
            hwr.GetRequestStream().Write(bodyStream, 0, bodyStream.Length);

            HttpWebResponse hwrs = hwr.GetResponse() as HttpWebResponse;
            CatchCookies(hwrs);

            richTextBox1.Text = JsonConvert.SerializeObject(hwrs);
            richTextBox1.Text += m_CookieValue;
        }

        private void meButton_Click(object sender, EventArgs e)
        {
            HttpWebRequest req = WebRequest.Create(@"https://commuter-application.herokuapp.com/authentication/me") as HttpWebRequest;
            AddCookies(req);

            HttpWebResponse res = req.GetResponse() as HttpWebResponse;

            richTextBox1.Text = JsonConvert.SerializeObject(res);
            richTextBox1.Text += new StreamReader(res.GetResponseStream()).ReadToEnd();
        }
    }
}
