﻿
namespace Britannia
{
    partial class AddGear
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
            this.btnAddShip = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lbxAddedGear = new System.Windows.Forms.ListBox();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddShip
            // 
            this.btnAddShip.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddShip.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddShip.Location = new System.Drawing.Point(84, 257);
            this.btnAddShip.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.btnAddShip.Name = "btnAddShip";
            this.btnAddShip.Size = new System.Drawing.Size(115, 35);
            this.btnAddShip.TabIndex = 0;
            this.btnAddShip.Text = "Add Gear";
            this.btnAddShip.UseVisualStyleBackColor = true;
            this.btnAddShip.Click += new System.EventHandler(this.btnAddShip_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lbxAddedGear);
            this.pnlMain.Controls.Add(this.btnAddShip);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(286, 311);
            this.pnlMain.TabIndex = 1;
            // 
            // lbxAddedGear
            // 
            this.lbxAddedGear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxAddedGear.FormattingEnabled = true;
            this.lbxAddedGear.ItemHeight = 20;
            this.lbxAddedGear.Location = new System.Drawing.Point(10, 14);
            this.lbxAddedGear.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.lbxAddedGear.Name = "lbxAddedGear";
            this.lbxAddedGear.Size = new System.Drawing.Size(266, 224);
            this.lbxAddedGear.TabIndex = 3;
            this.lbxAddedGear.SelectedIndexChanged += new System.EventHandler(this.lbxAddedShips_SelectedIndexChanged);
            // 
            // AddGear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 311);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 350);
            this.Name = "AddGear";
            this.Text = "Add Gear";
            this.Load += new System.EventHandler(this.AddGear_Load);
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddShip;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ListBox lbxAddedGear;
    }
}