// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace macapp
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        AppKit.NSTextField ClickedLabel { get; set; }

        [Outlet]
        AppKit.NSTextField txtAddress { get; set; }

        [Outlet]
        AppKit.NSTextField txtCity { get; set; }

        [Outlet]
        AppKit.NSTextField txtName { get; set; }

        [Outlet]
        AppKit.NSTextField txtPhone { get; set; }

        [Outlet]
        AppKit.NSTextField txtState { get; set; }

        [Outlet]
        AppKit.NSTextField txtTwitter { get; set; }

        [Outlet]
        AppKit.NSTextField txtZip { get; set; }

        [Action ("btnTestStudent:")]
        partial void btnTestStudent (Foundation.NSObject sender);

        [Action ("btnTestTeacher:")]
        partial void btnTestTeacher (Foundation.NSObject sender);

        [Action ("ClickedButton:")]
        partial void ClickedButton (Foundation.NSObject sender);
        
        void ReleaseDesignerOutlets ()
        {
            if (ClickedLabel != null) {
                ClickedLabel.Dispose ();
                ClickedLabel = null;
            }

            if (txtAddress != null) {
                txtAddress.Dispose ();
                txtAddress = null;
            }

            if (txtCity != null) {
                txtCity.Dispose ();
                txtCity = null;
            }

            if (txtName != null) {
                txtName.Dispose ();
                txtName = null;
            }

            if (txtPhone != null) {
                txtPhone.Dispose ();
                txtPhone = null;
            }

            if (txtState != null) {
                txtState.Dispose ();
                txtState = null;
            }

            if (txtTwitter != null) {
                txtTwitter.Dispose ();
                txtTwitter = null;
            }

            if (txtZip != null) {
                txtZip.Dispose ();
                txtZip = null;
            }
        }
    }
}
