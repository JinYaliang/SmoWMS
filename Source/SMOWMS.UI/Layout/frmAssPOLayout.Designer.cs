using System;
using Smobiler.Core;
namespace SMOWMS.UI.Layout
{
    partial class frmAssPOLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public frmAssPOLayout()
            : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
        }

        //SmobilerUserControl overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerUserControl
        //It can be modified using the SmobilerUserControl.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.svRow = new Smobiler.Core.Controls.SwipeView();
            this.plRow = new Smobiler.Core.Controls.Panel();
            this.lblName = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.lblPurchaser = new Smobiler.Core.Controls.Label();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.lblRealID = new Smobiler.Core.Controls.Label();
            this.lblStatus = new Smobiler.Core.Controls.Label();
            this.imgFirstAss = new Smobiler.Core.Controls.Image();
            this.ibEdit = new Smobiler.Core.Controls.ImageButton();
            // 
            // svRow
            // 
            this.svRow.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plRow});
            this.svRow.Name = "svRow";
            this.svRow.RightControlName = "svDelete";
            this.svRow.Size = new System.Drawing.Size(260, 90);
            // 
            // plRow
            // 
            this.plRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plRow.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblName,
            this.label4,
            this.lblPurchaser,
            this.label6,
            this.lblRealID,
            this.lblStatus,
            this.imgFirstAss,
            this.ibEdit});
            this.plRow.Name = "plRow";
            this.plRow.Size = new System.Drawing.Size(260, 90);
            this.plRow.Touchable = true;
            this.plRow.Press += new System.EventHandler(this.plRow_Press);
            // 
            // lblName
            // 
            this.lblName.DataMember = "POID";
            this.lblName.DisplayMember = "NAME";
            this.lblName.FontSize = 14F;
            this.lblName.Location = new System.Drawing.Point(85, 7);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.lblName.Size = new System.Drawing.Size(115, 25);
            this.lblName.Text = "label1";
            // 
            // label4
            // 
            this.label4.FontSize = 12F;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.label4.Location = new System.Drawing.Point(85, 57);
            this.label4.Name = "label4";
            this.label4.Padding = new Smobiler.Core.Controls.Padding(2F, 0F, 0F, 0F);
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.Text = "�ɹ���";
            // 
            // lblPurchaser
            // 
            this.lblPurchaser.DataMember = "PURCHASERNAME";
            this.lblPurchaser.DisplayMember = "PURCHASERNAME";
            this.lblPurchaser.FontSize = 12F;
            this.lblPurchaser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.lblPurchaser.Location = new System.Drawing.Point(140, 57);
            this.lblPurchaser.Name = "lblPurchaser";
            this.lblPurchaser.Size = new System.Drawing.Size(70, 25);
            this.lblPurchaser.Text = "label5";
            // 
            // label6
            // 
            this.label6.FontSize = 12F;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.label6.Location = new System.Drawing.Point(85, 32);
            this.label6.Name = "label6";
            this.label6.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label6.Size = new System.Drawing.Size(55, 25);
            this.label6.Text = "����";
            // 
            // lblRealID
            // 
            this.lblRealID.DataMember = "REALID";
            this.lblRealID.DisplayMember = "REALID";
            this.lblRealID.FontSize = 12F;
            this.lblRealID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.lblRealID.Location = new System.Drawing.Point(140, 32);
            this.lblRealID.Name = "lblRealID";
            this.lblRealID.Size = new System.Drawing.Size(120, 25);
            this.lblRealID.Text = "label7";
            // 
            // lblStatus
            // 
            this.lblStatus.DataMember = "STATUSNAME";
            this.lblStatus.DisplayMember = "STATUSNAME";
            this.lblStatus.FontSize = 14F;
            this.lblStatus.Location = new System.Drawing.Point(200, 7);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 25);
            // 
            // imgFirstAss
            // 
            this.imgFirstAss.DisplayMember = "Image";
            this.imgFirstAss.Location = new System.Drawing.Point(10, 7);
            this.imgFirstAss.Name = "imgFirstAss";
            this.imgFirstAss.Size = new System.Drawing.Size(75, 75);
            // 
            // ibEdit
            // 
            this.ibEdit.Location = new System.Drawing.Point(220, 60);
            this.ibEdit.Name = "ibEdit";
            this.ibEdit.ResourceID = "icon-edit";
            this.ibEdit.Size = new System.Drawing.Size(30, 30);
            this.ibEdit.Press += new System.EventHandler(this.ibEdit_Press);
            // 
            // frmAssPOLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.svRow});
            this.Size = new System.Drawing.Size(260, 90);
            this.Name = "frmAssPOLayout";

        }
        #endregion
        private Smobiler.Core.Controls.SwipeView svRow;
        private Smobiler.Core.Controls.Panel plRow;
        private Smobiler.Core.Controls.Label lblName;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.Label lblPurchaser;
        private Smobiler.Core.Controls.Label label6;
        private Smobiler.Core.Controls.Label lblRealID;
        public Smobiler.Core.Controls.Label lblStatus;
        private Smobiler.Core.Controls.Image imgFirstAss;
        internal Smobiler.Core.Controls.ImageButton ibEdit;
    }
}