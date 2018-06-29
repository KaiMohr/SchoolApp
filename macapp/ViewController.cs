using System;

using AppKit;
using Foundation;
namespace macapp
{
    public partial class ViewController : NSViewController
    {
        private int numberOfTimesClicked = 0;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        partial void ClickedButton(Foundation.NSObject sender)
        {

            // Update counter and label
            ClickedLabel.StringValue = string.Format("The button has been clicked {0} time{1}.", ++numberOfTimesClicked, (numberOfTimesClicked < 2) ? "" : "s");

            var testSchool = new School();
            testSchool.Name = txtName.StringValue; // "Central City High";
            testSchool.Address = txtAddress.StringValue;
            testSchool.City = txtCity.StringValue;
            testSchool.State = txtState.StringValue;
            testSchool.Zip = txtZip.StringValue;
            testSchool.PhoneNumber = txtPhone.StringValue;
            try
            {
                testSchool.TwitterAddress = txtTwitter.StringValue; //@City High 
            } catch (Exception ex)
            {
                var alert = new NSAlert();
                alert.MessageText = "error";
                alert.InformativeText = ex.Message;
                alert.RunModal();
            }
        
            var resultWindow = new NSAlert();
            resultWindow.MessageText = "result";
            resultWindow.InformativeText = testSchool.ToString();
            resultWindow.RunModal();
        }
       
        partial void btnTestTeacher(Foundation.NSObject sender)
        {
            ClickedLabel.StringValue = string.Format("The button has been clicked {0} time{1}.", ++numberOfTimesClicked, (numberOfTimesClicked < 2) ? "" : "s");
            var teacher = new Teacher();
            var gp = teacher.ComputeGradeAverage();

            var gpWindow = new NSAlert();
            gpWindow.MessageText = "grade average";
            gpWindow.InformativeText = "the grade is " + gp;
            gpWindow.RunModal();
        }

        partial void btnTestStudent(Foundation.NSObject sender)
        {
            var student = new Student();
            var gp = student.ComputeGradeAverage();

            var gpWindow = new NSAlert();
            gpWindow.InformativeText = "the grade is" + gp;
            gpWindow.RunModal();

        }

    }
}
