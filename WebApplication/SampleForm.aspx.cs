using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class SampleForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["TestValue"] != null)
            {
                lblSessionValue.Text = "Session Value: " + Session["TestValue"].ToString();
            }
            else
            {
                lblSessionValue.Text = "Session Value is not set.";
            }
        }

        protected void btnSetSession_Click(object sender, EventArgs e)
        {
            Session["TestValue"] = txtInput.Text;
            lblSessionValue.Text = "Session Value: " + Session["TestValue"].ToString();
        }

        protected void btnClearSession_Click(object sender, EventArgs e)
        {
            if (Session["Subscriber"] == null)
            {
                lblSessionValue.Text = "Session Value is not set.";
            }
            else
            {
                Session["TestValue"] = null;
                Session["Subscriber"] = null;
                lblSessionValue.Text = "Session Value is Cleared.";
            }
        }

        protected void btnGenSubscriber_Click(object sender, EventArgs e)
        {
            Subscriber subscriber = Subscriber.GetRandomSubscriber();
            //Session["Subscriber"] = Subscriber.Serialize(subscriber);
            lblSubscriber.Text = "New Subscriber generated: " + subscriber.ToString();
            txtInputSubId.Text = subscriber.Id.ToString();
            txtInputSubName.Text = subscriber.Name;
            txtInputSubEmail.Text = subscriber.Email;
            txtInputSubMsisdn.Text = subscriber.Msisdn;
        }

        protected void btnSaveSubscriber_Click(object sender, EventArgs e)
        {
            if(long.TryParse(txtInputSubId.Text, out long id) == false)
            {
                lblSubscriber.Text = "Invalid Id";
                return;
            }
            Subscriber subscriber = new Subscriber
            {
                Id = long.Parse(txtInputSubId.Text),
                Name = txtInputSubName.Text,
                Email = txtInputSubEmail.Text,
                Msisdn = txtInputSubMsisdn.Text
            };
            Session["Subscriber"] = Subscriber.Serialize(subscriber);
            lblSubscriber.Text = "Subscriber saved in session: " + subscriber.ToString();
        }

        protected void btnLoadSubscriber_Click(object sender, EventArgs e)
        {
            if (Session["Subscriber"] != null)
            {
                Subscriber subscriber = Subscriber.Deserialize(Session["Subscriber"].ToString());
                lblSubscriber.Text = "Subscriber loaded from session: " + subscriber.ToString();
                txtInputSubId.Text = subscriber.Id.ToString();
                txtInputSubName.Text = subscriber.Name;
                txtInputSubEmail.Text = subscriber.Email;
                txtInputSubMsisdn.Text = subscriber.Msisdn;
            }
            else
            {
                Clear();
                lblSubscriber.Text = "No subscriber found in session.";
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        protected void Clear()
        {
            txtInputSubId.Text = "";
            txtInputSubName.Text = "";
            txtInputSubEmail.Text = "";
            txtInputSubMsisdn.Text = "";
            lblSubscriber.Text = "";
        }
    }
}