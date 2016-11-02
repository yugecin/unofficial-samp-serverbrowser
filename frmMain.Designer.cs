﻿namespace yugecin.sampbrowser
{
	partial class frmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pnlControls = new System.Windows.Forms.Panel();
			this.lstServers = new System.Windows.Forms.ListView();
			this.colPW = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colHostName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colPlayers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colPing = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colMode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colLanguage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lblStatus = new System.Windows.Forms.Label();
			this.btnConnect = new System.Windows.Forms.Button();
			this.btnQuickconnect = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtFilterHostname = new System.Windows.Forms.TextBox();
			this.pnlFilters = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.txtFilterMode = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtFilterLang = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.chlFilterNoPW = new System.Windows.Forms.CheckBox();
			this.chkFilterNotFull = new System.Windows.Forms.CheckBox();
			this.chkFilterNotEmpty = new System.Windows.Forms.CheckBox();
			this.chkFilterOnline = new System.Windows.Forms.CheckBox();
			this.pnlControls.SuspendLayout();
			this.pnlFilters.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlControls
			// 
			this.pnlControls.Controls.Add(this.label5);
			this.pnlControls.Controls.Add(this.txtName);
			this.pnlControls.Controls.Add(this.btnQuickconnect);
			this.pnlControls.Controls.Add(this.btnConnect);
			this.pnlControls.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlControls.Location = new System.Drawing.Point(0, 0);
			this.pnlControls.Margin = new System.Windows.Forms.Padding(0);
			this.pnlControls.Name = "pnlControls";
			this.pnlControls.Size = new System.Drawing.Size(792, 24);
			this.pnlControls.TabIndex = 0;
			// 
			// lstServers
			// 
			this.lstServers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstServers.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lstServers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPW,
            this.colHostName,
            this.colPlayers,
            this.colPing,
            this.colMode,
            this.colLanguage});
			this.lstServers.FullRowSelect = true;
			this.lstServers.GridLines = true;
			this.lstServers.HideSelection = false;
			this.lstServers.Location = new System.Drawing.Point(0, 24);
			this.lstServers.Margin = new System.Windows.Forms.Padding(0);
			this.lstServers.MultiSelect = false;
			this.lstServers.Name = "lstServers";
			this.lstServers.Size = new System.Drawing.Size(598, 404);
			this.lstServers.TabIndex = 0;
			this.lstServers.UseCompatibleStateImageBehavior = false;
			this.lstServers.View = System.Windows.Forms.View.Details;
			// 
			// colPW
			// 
			this.colPW.Text = "PW";
			this.colPW.Width = 30;
			// 
			// colHostName
			// 
			this.colHostName.Text = "HostName";
			this.colHostName.Width = 250;
			// 
			// colPlayers
			// 
			this.colPlayers.Text = "Players";
			// 
			// colPing
			// 
			this.colPing.Text = "Ping";
			// 
			// colMode
			// 
			this.colMode.Text = "Mode";
			this.colMode.Width = 100;
			// 
			// colLanguage
			// 
			this.colLanguage.Text = "Language";
			this.colLanguage.Width = 90;
			// 
			// lblStatus
			// 
			this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lblStatus.Location = new System.Drawing.Point(0, 448);
			this.lblStatus.Margin = new System.Windows.Forms.Padding(0);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(792, 25);
			this.lblStatus.TabIndex = 2;
			this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(0, 1);
			this.btnConnect.Margin = new System.Windows.Forms.Padding(0);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(66, 23);
			this.btnConnect.TabIndex = 1;
			this.btnConnect.Text = "Connect";
			this.btnConnect.UseVisualStyleBackColor = true;
			// 
			// btnQuickconnect
			// 
			this.btnQuickconnect.Location = new System.Drawing.Point(66, 1);
			this.btnQuickconnect.Margin = new System.Windows.Forms.Padding(0);
			this.btnQuickconnect.Name = "btnQuickconnect";
			this.btnQuickconnect.Size = new System.Drawing.Size(95, 23);
			this.btnQuickconnect.TabIndex = 2;
			this.btnQuickconnect.Text = "Quick connect";
			this.btnQuickconnect.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(0, -1);
			this.label2.Margin = new System.Windows.Forms.Padding(0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "HostName";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtFilterHostname
			// 
			this.txtFilterHostname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtFilterHostname.Location = new System.Drawing.Point(60, 0);
			this.txtFilterHostname.Margin = new System.Windows.Forms.Padding(0);
			this.txtFilterHostname.Name = "txtFilterHostname";
			this.txtFilterHostname.Size = new System.Drawing.Size(113, 20);
			this.txtFilterHostname.TabIndex = 4;
			// 
			// pnlFilters
			// 
			this.pnlFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlFilters.Controls.Add(this.chkFilterOnline);
			this.pnlFilters.Controls.Add(this.chkFilterNotEmpty);
			this.pnlFilters.Controls.Add(this.chkFilterNotFull);
			this.pnlFilters.Controls.Add(this.chlFilterNoPW);
			this.pnlFilters.Controls.Add(this.label4);
			this.pnlFilters.Controls.Add(this.txtFilterLang);
			this.pnlFilters.Controls.Add(this.label3);
			this.pnlFilters.Controls.Add(this.txtFilterMode);
			this.pnlFilters.Controls.Add(this.label2);
			this.pnlFilters.Controls.Add(this.txtFilterHostname);
			this.pnlFilters.Location = new System.Drawing.Point(0, 428);
			this.pnlFilters.Margin = new System.Windows.Forms.Padding(0);
			this.pnlFilters.Name = "pnlFilters";
			this.pnlFilters.Size = new System.Drawing.Size(792, 20);
			this.pnlFilters.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(173, -1);
			this.label3.Margin = new System.Windows.Forms.Padding(0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "Mode";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtFilterMode
			// 
			this.txtFilterMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtFilterMode.Location = new System.Drawing.Point(233, 0);
			this.txtFilterMode.Margin = new System.Windows.Forms.Padding(0);
			this.txtFilterMode.Name = "txtFilterMode";
			this.txtFilterMode.Size = new System.Drawing.Size(113, 20);
			this.txtFilterMode.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(346, -1);
			this.label4.Margin = new System.Windows.Forms.Padding(0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 20);
			this.label4.TabIndex = 8;
			this.label4.Text = "Language";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtFilterLang
			// 
			this.txtFilterLang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtFilterLang.Location = new System.Drawing.Point(406, 0);
			this.txtFilterLang.Margin = new System.Windows.Forms.Padding(0);
			this.txtFilterLang.Name = "txtFilterLang";
			this.txtFilterLang.Size = new System.Drawing.Size(113, 20);
			this.txtFilterLang.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(161, 1);
			this.label5.Margin = new System.Windows.Forms.Padding(0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(77, 23);
			this.label5.TabIndex = 10;
			this.label5.Text = "Name";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtName
			// 
			this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtName.Location = new System.Drawing.Point(238, 3);
			this.txtName.Margin = new System.Windows.Forms.Padding(0);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(150, 20);
			this.txtName.TabIndex = 11;
			// 
			// chlFilterNoPW
			// 
			this.chlFilterNoPW.AutoSize = true;
			this.chlFilterNoPW.Location = new System.Drawing.Point(531, 1);
			this.chlFilterNoPW.Margin = new System.Windows.Forms.Padding(0);
			this.chlFilterNoPW.Name = "chlFilterNoPW";
			this.chlFilterNoPW.Size = new System.Drawing.Size(58, 18);
			this.chlFilterNoPW.TabIndex = 10;
			this.chlFilterNoPW.Text = "No PW";
			this.chlFilterNoPW.UseVisualStyleBackColor = true;
			// 
			// chkFilterNotFull
			// 
			this.chkFilterNotFull.AutoSize = true;
			this.chkFilterNotFull.Location = new System.Drawing.Point(589, 1);
			this.chkFilterNotFull.Margin = new System.Windows.Forms.Padding(0);
			this.chkFilterNotFull.Name = "chkFilterNotFull";
			this.chkFilterNotFull.Size = new System.Drawing.Size(61, 18);
			this.chkFilterNotFull.TabIndex = 11;
			this.chkFilterNotFull.Text = "Not Full";
			this.chkFilterNotFull.UseVisualStyleBackColor = true;
			// 
			// chkFilterNotEmpty
			// 
			this.chkFilterNotEmpty.AutoSize = true;
			this.chkFilterNotEmpty.Location = new System.Drawing.Point(650, 1);
			this.chkFilterNotEmpty.Margin = new System.Windows.Forms.Padding(0);
			this.chkFilterNotEmpty.Name = "chkFilterNotEmpty";
			this.chkFilterNotEmpty.Size = new System.Drawing.Size(74, 18);
			this.chkFilterNotEmpty.TabIndex = 12;
			this.chkFilterNotEmpty.Text = "Not Empty";
			this.chkFilterNotEmpty.UseVisualStyleBackColor = true;
			// 
			// chkFilterOnline
			// 
			this.chkFilterOnline.AutoSize = true;
			this.chkFilterOnline.Location = new System.Drawing.Point(724, 1);
			this.chkFilterOnline.Margin = new System.Windows.Forms.Padding(0);
			this.chkFilterOnline.Name = "chkFilterOnline";
			this.chkFilterOnline.Size = new System.Drawing.Size(56, 18);
			this.chkFilterOnline.TabIndex = 13;
			this.chkFilterOnline.Text = "Online";
			this.chkFilterOnline.UseVisualStyleBackColor = true;
			// 
			// frmMain
			// 
			this.AcceptButton = this.btnConnect;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(792, 473);
			this.Controls.Add(this.pnlFilters);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.lstServers);
			this.Controls.Add(this.pnlControls);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MinimumSize = new System.Drawing.Size(800, 500);
			this.Name = "frmMain";
			this.Text = "SA-MP serverbrowser";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
			this.pnlControls.ResumeLayout(false);
			this.pnlControls.PerformLayout();
			this.pnlFilters.ResumeLayout(false);
			this.pnlFilters.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlControls;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.ListView lstServers;
		private System.Windows.Forms.ColumnHeader colPW;
		private System.Windows.Forms.ColumnHeader colHostName;
		private System.Windows.Forms.ColumnHeader colPlayers;
		private System.Windows.Forms.ColumnHeader colPing;
		private System.Windows.Forms.ColumnHeader colMode;
		private System.Windows.Forms.ColumnHeader colLanguage;
		private System.Windows.Forms.Button btnQuickconnect;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtFilterHostname;
		private System.Windows.Forms.Panel pnlFilters;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtFilterLang;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtFilterMode;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.CheckBox chkFilterNotEmpty;
		private System.Windows.Forms.CheckBox chkFilterNotFull;
		private System.Windows.Forms.CheckBox chlFilterNoPW;
		private System.Windows.Forms.CheckBox chkFilterOnline;
	}
}