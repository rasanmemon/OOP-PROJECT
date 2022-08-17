namespace EducationManagementSystem
{
    partial class TeacherPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherPanel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logout_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Marks_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.CF_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TAttendance_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SAttendance_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SRecord_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Dashboard_Button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.cF_TeacherPanel1 = new EducationManagementSystem.CF_TeacherPanel();
            this.sA_TeacherPanel1 = new EducationManagementSystem.SA_TeacherPanel();
            this.sR_Teacher1 = new EducationManagementSystem.SR_Teacher();
            this.dashboard_TeacherPanel1 = new EducationManagementSystem.Dashboard_TeacherPanel();
            this.tA_Teacher1 = new EducationManagementSystem.TA_Teacher();
            this.marks_Teacher1 = new EducationManagementSystem.Marks_Teacher();
            this.MouseDetect = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.panel1.Controls.Add(this.Logout_Button);
            this.panel1.Controls.Add(this.Marks_Button);
            this.panel1.Controls.Add(this.CF_Button);
            this.panel1.Controls.Add(this.TAttendance_Button);
            this.panel1.Controls.Add(this.SAttendance_Button);
            this.panel1.Controls.Add(this.SRecord_Button);
            this.panel1.Controls.Add(this.Dashboard_Button);
            this.panel1.Controls.Add(this.panel2);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(52, 501);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Logout_Button
            // 
            this.Logout_Button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(88)))));
            this.Logout_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.Logout_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logout_Button.BorderRadius = 0;
            this.Logout_Button.ButtonText = "Logout";
            this.Logout_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.Logout_Button, BunifuAnimatorNS.DecorationType.None);
            this.Logout_Button.DisabledColor = System.Drawing.Color.Gray;
            this.Logout_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logout_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Logout_Button.Iconimage = global::EducationManagementSystem.Properties.Resources.logout_rounded_down_32px;
            this.Logout_Button.Iconimage_right = null;
            this.Logout_Button.Iconimage_right_Selected = null;
            this.Logout_Button.Iconimage_Selected = null;
            this.Logout_Button.IconMarginLeft = 0;
            this.Logout_Button.IconMarginRight = 0;
            this.Logout_Button.IconRightVisible = true;
            this.Logout_Button.IconRightZoom = 0D;
            this.Logout_Button.IconVisible = true;
            this.Logout_Button.IconZoom = 90D;
            this.Logout_Button.IsTab = false;
            this.Logout_Button.Location = new System.Drawing.Point(0, 388);
            this.Logout_Button.Name = "Logout_Button";
            this.Logout_Button.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.Logout_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(88)))));
            this.Logout_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.Logout_Button.selected = false;
            this.Logout_Button.Size = new System.Drawing.Size(52, 48);
            this.Logout_Button.TabIndex = 9;
            this.Logout_Button.Text = "Logout";
            this.Logout_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Logout_Button.Textcolor = System.Drawing.Color.White;
            this.Logout_Button.TextFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_Button.Click += new System.EventHandler(this.Logout_Button_Click);
            // 
            // Marks_Button
            // 
            this.Marks_Button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(88)))));
            this.Marks_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.Marks_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Marks_Button.BorderRadius = 0;
            this.Marks_Button.ButtonText = "Marks";
            this.Marks_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.Marks_Button, BunifuAnimatorNS.DecorationType.None);
            this.Marks_Button.DisabledColor = System.Drawing.Color.Gray;
            this.Marks_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Marks_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Marks_Button.Iconimage = global::EducationManagementSystem.Properties.Resources.report_card_32px;
            this.Marks_Button.Iconimage_right = null;
            this.Marks_Button.Iconimage_right_Selected = null;
            this.Marks_Button.Iconimage_Selected = null;
            this.Marks_Button.IconMarginLeft = 0;
            this.Marks_Button.IconMarginRight = 0;
            this.Marks_Button.IconRightVisible = true;
            this.Marks_Button.IconRightZoom = 0D;
            this.Marks_Button.IconVisible = true;
            this.Marks_Button.IconZoom = 90D;
            this.Marks_Button.IsTab = false;
            this.Marks_Button.Location = new System.Drawing.Point(0, 340);
            this.Marks_Button.Name = "Marks_Button";
            this.Marks_Button.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.Marks_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(88)))));
            this.Marks_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.Marks_Button.selected = false;
            this.Marks_Button.Size = new System.Drawing.Size(52, 48);
            this.Marks_Button.TabIndex = 8;
            this.Marks_Button.Text = "Marks";
            this.Marks_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Marks_Button.Textcolor = System.Drawing.Color.White;
            this.Marks_Button.TextFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Marks_Button.Click += new System.EventHandler(this.Marks_Button_Click);
            // 
            // CF_Button
            // 
            this.CF_Button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(88)))));
            this.CF_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.CF_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CF_Button.BorderRadius = 0;
            this.CF_Button.ButtonText = "Course Feedback";
            this.CF_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.CF_Button, BunifuAnimatorNS.DecorationType.None);
            this.CF_Button.DisabledColor = System.Drawing.Color.Gray;
            this.CF_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.CF_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.CF_Button.Iconimage = global::EducationManagementSystem.Properties.Resources.feedback_32px;
            this.CF_Button.Iconimage_right = null;
            this.CF_Button.Iconimage_right_Selected = null;
            this.CF_Button.Iconimage_Selected = null;
            this.CF_Button.IconMarginLeft = 0;
            this.CF_Button.IconMarginRight = 0;
            this.CF_Button.IconRightVisible = true;
            this.CF_Button.IconRightZoom = 0D;
            this.CF_Button.IconVisible = true;
            this.CF_Button.IconZoom = 90D;
            this.CF_Button.IsTab = false;
            this.CF_Button.Location = new System.Drawing.Point(0, 292);
            this.CF_Button.Name = "CF_Button";
            this.CF_Button.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.CF_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(88)))));
            this.CF_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.CF_Button.selected = false;
            this.CF_Button.Size = new System.Drawing.Size(52, 48);
            this.CF_Button.TabIndex = 7;
            this.CF_Button.Text = "Course Feedback";
            this.CF_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CF_Button.Textcolor = System.Drawing.Color.White;
            this.CF_Button.TextFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CF_Button.Click += new System.EventHandler(this.CF_Button_Click);
            // 
            // TAttendance_Button
            // 
            this.TAttendance_Button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(88)))));
            this.TAttendance_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.TAttendance_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TAttendance_Button.BorderRadius = 0;
            this.TAttendance_Button.ButtonText = "T Attendance";
            this.TAttendance_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.TAttendance_Button, BunifuAnimatorNS.DecorationType.None);
            this.TAttendance_Button.DisabledColor = System.Drawing.Color.Gray;
            this.TAttendance_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.TAttendance_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.TAttendance_Button.Iconimage = global::EducationManagementSystem.Properties.Resources.front_desk_32px;
            this.TAttendance_Button.Iconimage_right = null;
            this.TAttendance_Button.Iconimage_right_Selected = null;
            this.TAttendance_Button.Iconimage_Selected = null;
            this.TAttendance_Button.IconMarginLeft = 0;
            this.TAttendance_Button.IconMarginRight = 0;
            this.TAttendance_Button.IconRightVisible = true;
            this.TAttendance_Button.IconRightZoom = 0D;
            this.TAttendance_Button.IconVisible = true;
            this.TAttendance_Button.IconZoom = 90D;
            this.TAttendance_Button.IsTab = false;
            this.TAttendance_Button.Location = new System.Drawing.Point(0, 244);
            this.TAttendance_Button.Name = "TAttendance_Button";
            this.TAttendance_Button.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.TAttendance_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(88)))));
            this.TAttendance_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.TAttendance_Button.selected = false;
            this.TAttendance_Button.Size = new System.Drawing.Size(52, 48);
            this.TAttendance_Button.TabIndex = 6;
            this.TAttendance_Button.Text = "T Attendance";
            this.TAttendance_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TAttendance_Button.Textcolor = System.Drawing.Color.White;
            this.TAttendance_Button.TextFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TAttendance_Button.Click += new System.EventHandler(this.TAttendance_Button_Click);
            // 
            // SAttendance_Button
            // 
            this.SAttendance_Button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(88)))));
            this.SAttendance_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.SAttendance_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SAttendance_Button.BorderRadius = 0;
            this.SAttendance_Button.ButtonText = "S Attendance";
            this.SAttendance_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.SAttendance_Button, BunifuAnimatorNS.DecorationType.None);
            this.SAttendance_Button.DisabledColor = System.Drawing.Color.Gray;
            this.SAttendance_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.SAttendance_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.SAttendance_Button.Iconimage = global::EducationManagementSystem.Properties.Resources.attendance_32px;
            this.SAttendance_Button.Iconimage_right = null;
            this.SAttendance_Button.Iconimage_right_Selected = null;
            this.SAttendance_Button.Iconimage_Selected = null;
            this.SAttendance_Button.IconMarginLeft = 0;
            this.SAttendance_Button.IconMarginRight = 0;
            this.SAttendance_Button.IconRightVisible = true;
            this.SAttendance_Button.IconRightZoom = 0D;
            this.SAttendance_Button.IconVisible = true;
            this.SAttendance_Button.IconZoom = 90D;
            this.SAttendance_Button.IsTab = false;
            this.SAttendance_Button.Location = new System.Drawing.Point(0, 196);
            this.SAttendance_Button.Name = "SAttendance_Button";
            this.SAttendance_Button.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.SAttendance_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(88)))));
            this.SAttendance_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.SAttendance_Button.selected = false;
            this.SAttendance_Button.Size = new System.Drawing.Size(52, 48);
            this.SAttendance_Button.TabIndex = 5;
            this.SAttendance_Button.Text = "S Attendance";
            this.SAttendance_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SAttendance_Button.Textcolor = System.Drawing.Color.White;
            this.SAttendance_Button.TextFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAttendance_Button.Click += new System.EventHandler(this.SAttendance_Button_Click);
            // 
            // SRecord_Button
            // 
            this.SRecord_Button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(88)))));
            this.SRecord_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.SRecord_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SRecord_Button.BorderRadius = 0;
            this.SRecord_Button.ButtonText = "S Record";
            this.SRecord_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.SRecord_Button, BunifuAnimatorNS.DecorationType.None);
            this.SRecord_Button.DisabledColor = System.Drawing.Color.Gray;
            this.SRecord_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.SRecord_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.SRecord_Button.Iconimage = global::EducationManagementSystem.Properties.Resources.student_registration_32px;
            this.SRecord_Button.Iconimage_right = null;
            this.SRecord_Button.Iconimage_right_Selected = null;
            this.SRecord_Button.Iconimage_Selected = null;
            this.SRecord_Button.IconMarginLeft = 0;
            this.SRecord_Button.IconMarginRight = 0;
            this.SRecord_Button.IconRightVisible = true;
            this.SRecord_Button.IconRightZoom = 0D;
            this.SRecord_Button.IconVisible = true;
            this.SRecord_Button.IconZoom = 90D;
            this.SRecord_Button.IsTab = false;
            this.SRecord_Button.Location = new System.Drawing.Point(0, 148);
            this.SRecord_Button.Name = "SRecord_Button";
            this.SRecord_Button.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.SRecord_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(88)))));
            this.SRecord_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.SRecord_Button.selected = false;
            this.SRecord_Button.Size = new System.Drawing.Size(52, 48);
            this.SRecord_Button.TabIndex = 3;
            this.SRecord_Button.Text = "S Record";
            this.SRecord_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SRecord_Button.Textcolor = System.Drawing.Color.White;
            this.SRecord_Button.TextFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SRecord_Button.Click += new System.EventHandler(this.SRecord_Button_Click);
            // 
            // Dashboard_Button
            // 
            this.Dashboard_Button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(88)))));
            this.Dashboard_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.Dashboard_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Dashboard_Button.BorderRadius = 0;
            this.Dashboard_Button.ButtonText = "Dashboard";
            this.Dashboard_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.Dashboard_Button, BunifuAnimatorNS.DecorationType.None);
            this.Dashboard_Button.DisabledColor = System.Drawing.Color.Gray;
            this.Dashboard_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Dashboard_Button.Iconcolor = System.Drawing.Color.Transparent;
            this.Dashboard_Button.Iconimage = global::EducationManagementSystem.Properties.Resources.menu_32px;
            this.Dashboard_Button.Iconimage_right = null;
            this.Dashboard_Button.Iconimage_right_Selected = null;
            this.Dashboard_Button.Iconimage_Selected = null;
            this.Dashboard_Button.IconMarginLeft = 0;
            this.Dashboard_Button.IconMarginRight = 0;
            this.Dashboard_Button.IconRightVisible = true;
            this.Dashboard_Button.IconRightZoom = 0D;
            this.Dashboard_Button.IconVisible = true;
            this.Dashboard_Button.IconZoom = 90D;
            this.Dashboard_Button.IsTab = true;
            this.Dashboard_Button.Location = new System.Drawing.Point(0, 100);
            this.Dashboard_Button.Name = "Dashboard_Button";
            this.Dashboard_Button.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(38)))), ((int)(((byte)(126)))));
            this.Dashboard_Button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(88)))));
            this.Dashboard_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.Dashboard_Button.selected = true;
            this.Dashboard_Button.Size = new System.Drawing.Size(52, 48);
            this.Dashboard_Button.TabIndex = 2;
            this.Dashboard_Button.Text = "Dashboard";
            this.Dashboard_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Dashboard_Button.Textcolor = System.Drawing.Color.White;
            this.Dashboard_Button.TextFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard_Button.Click += new System.EventHandler(this.Dashboard_Button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(52, 100);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = global::EducationManagementSystem.Properties.Resources.Academic_Records_Logo_011;
            this.pictureBox2.Location = new System.Drawing.Point(0, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::EducationManagementSystem.Properties.Resources.Shutdown;
            this.pictureBox1.Location = new System.Drawing.Point(4, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // cF_TeacherPanel1
            // 
            this.bunifuTransition1.SetDecoration(this.cF_TeacherPanel1, BunifuAnimatorNS.DecorationType.None);
            this.cF_TeacherPanel1.Location = new System.Drawing.Point(53, 0);
            this.cF_TeacherPanel1.Name = "cF_TeacherPanel1";
            this.cF_TeacherPanel1.Size = new System.Drawing.Size(690, 501);
            this.cF_TeacherPanel1.TabIndex = 5;
            // 
            // sA_TeacherPanel1
            // 
            this.bunifuTransition1.SetDecoration(this.sA_TeacherPanel1, BunifuAnimatorNS.DecorationType.None);
            this.sA_TeacherPanel1.Location = new System.Drawing.Point(54, 0);
            this.sA_TeacherPanel1.Name = "sA_TeacherPanel1";
            this.sA_TeacherPanel1.Size = new System.Drawing.Size(690, 501);
            this.sA_TeacherPanel1.TabIndex = 4;
            this.sA_TeacherPanel1.Load += new System.EventHandler(this.sA_TeacherPanel1_Load);
            // 
            // sR_Teacher1
            // 
            this.bunifuTransition1.SetDecoration(this.sR_Teacher1, BunifuAnimatorNS.DecorationType.None);
            this.sR_Teacher1.Location = new System.Drawing.Point(51, 0);
            this.sR_Teacher1.Name = "sR_Teacher1";
            this.sR_Teacher1.Size = new System.Drawing.Size(690, 501);
            this.sR_Teacher1.TabIndex = 3;
            this.sR_Teacher1.Load += new System.EventHandler(this.sR_Teacher1_Load);
            // 
            // dashboard_TeacherPanel1
            // 
            this.dashboard_TeacherPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dashboard_TeacherPanel1.BackgroundImage")));
            this.dashboard_TeacherPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuTransition1.SetDecoration(this.dashboard_TeacherPanel1, BunifuAnimatorNS.DecorationType.None);
            this.dashboard_TeacherPanel1.Location = new System.Drawing.Point(54, 0);
            this.dashboard_TeacherPanel1.Name = "dashboard_TeacherPanel1";
            this.dashboard_TeacherPanel1.Size = new System.Drawing.Size(691, 501);
            this.dashboard_TeacherPanel1.TabIndex = 2;
            // 
            // tA_Teacher1
            // 
            this.bunifuTransition1.SetDecoration(this.tA_Teacher1, BunifuAnimatorNS.DecorationType.None);
            this.tA_Teacher1.Location = new System.Drawing.Point(53, 0);
            this.tA_Teacher1.Name = "tA_Teacher1";
            this.tA_Teacher1.Size = new System.Drawing.Size(690, 501);
            this.tA_Teacher1.TabIndex = 6;
            // 
            // marks_Teacher1
            // 
            this.bunifuTransition1.SetDecoration(this.marks_Teacher1, BunifuAnimatorNS.DecorationType.None);
            this.marks_Teacher1.Location = new System.Drawing.Point(53, 0);
            this.marks_Teacher1.Name = "marks_Teacher1";
            this.marks_Teacher1.Size = new System.Drawing.Size(690, 501);
            this.marks_Teacher1.TabIndex = 7;
            // 
            // MouseDetect
            // 
            this.MouseDetect.Enabled = true;
            this.MouseDetect.Tick += new System.EventHandler(this.MouseDetect_Tick);
            // 
            // TeacherPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 501);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.marks_Teacher1);
            this.Controls.Add(this.tA_Teacher1);
            this.Controls.Add(this.cF_TeacherPanel1);
            this.Controls.Add(this.sA_TeacherPanel1);
            this.Controls.Add(this.sR_Teacher1);
            this.Controls.Add(this.dashboard_TeacherPanel1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TeacherPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherPanel";
            this.Load += new System.EventHandler(this.TeacherPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton Logout_Button;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuFlatButton Marks_Button;
        private Bunifu.Framework.UI.BunifuFlatButton CF_Button;
        private Bunifu.Framework.UI.BunifuFlatButton SAttendance_Button;
        private Bunifu.Framework.UI.BunifuFlatButton SRecord_Button;
        private Bunifu.Framework.UI.BunifuFlatButton Dashboard_Button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer MouseDetect;
        private Bunifu.Framework.UI.BunifuFlatButton TAttendance_Button;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Dashboard_TeacherPanel dashboard_TeacherPanel1;
        private SR_Teacher sR_Teacher1;
        private SA_TeacherPanel sA_TeacherPanel1;
        private CF_TeacherPanel cF_TeacherPanel1;
        private TA_Teacher tA_Teacher1;
        private Marks_Teacher marks_Teacher1;
    }
}