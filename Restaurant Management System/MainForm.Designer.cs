﻿namespace Restaurant_Management_System
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.customers_btn = new System.Windows.Forms.Button();
            this.categories_btn = new System.Windows.Forms.Button();
            this.inventory_btn = new System.Windows.Forms.Button();
            this.shop_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customersForm1 = new Restaurant_Management_System.customersForm();
            this.categoryForm1 = new Restaurant_Management_System.categoryForm();
            this.inventoryForm1 = new Restaurant_Management_System.inventoryForm();
            this.shopForm1 = new Restaurant_Management_System.shopForm();
            this.dashboardForm1 = new Restaurant_Management_System.dashboardForm();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 35);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Restaurant Management System";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1153, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(76)))), ((int)(((byte)(65)))));
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.customers_btn);
            this.panel2.Controls.Add(this.categories_btn);
            this.panel2.Controls.Add(this.inventory_btn);
            this.panel2.Controls.Add(this.shop_btn);
            this.panel2.Controls.Add(this.dashboard_btn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 767);
            this.panel2.TabIndex = 3;
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(130)))), ((int)(((byte)(98)))));
            this.logout_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(130)))), ((int)(((byte)(98)))));
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Location = new System.Drawing.Point(60, 710);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(166, 45);
            this.logout_btn.TabIndex = 9;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.button7_Click);
            // 
            // customers_btn
            // 
            this.customers_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.customers_btn.FlatAppearance.BorderSize = 0;
            this.customers_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(130)))), ((int)(((byte)(98)))));
            this.customers_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(130)))), ((int)(((byte)(98)))));
            this.customers_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customers_btn.ForeColor = System.Drawing.Color.White;
            this.customers_btn.Location = new System.Drawing.Point(59, 477);
            this.customers_btn.Name = "customers_btn";
            this.customers_btn.Size = new System.Drawing.Size(166, 45);
            this.customers_btn.TabIndex = 8;
            this.customers_btn.Text = "Customers";
            this.customers_btn.UseVisualStyleBackColor = false;
            this.customers_btn.Click += new System.EventHandler(this.button6_Click);
            // 
            // categories_btn
            // 
            this.categories_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.categories_btn.FlatAppearance.BorderSize = 0;
            this.categories_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(130)))), ((int)(((byte)(98)))));
            this.categories_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(130)))), ((int)(((byte)(98)))));
            this.categories_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categories_btn.ForeColor = System.Drawing.Color.White;
            this.categories_btn.Location = new System.Drawing.Point(59, 406);
            this.categories_btn.Name = "categories_btn";
            this.categories_btn.Size = new System.Drawing.Size(166, 45);
            this.categories_btn.TabIndex = 7;
            this.categories_btn.Text = "Categories";
            this.categories_btn.UseVisualStyleBackColor = false;
            this.categories_btn.Click += new System.EventHandler(this.categories_btn_Click);
            // 
            // inventory_btn
            // 
            this.inventory_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.inventory_btn.FlatAppearance.BorderSize = 0;
            this.inventory_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(130)))), ((int)(((byte)(98)))));
            this.inventory_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(130)))), ((int)(((byte)(98)))));
            this.inventory_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventory_btn.ForeColor = System.Drawing.Color.White;
            this.inventory_btn.Location = new System.Drawing.Point(59, 338);
            this.inventory_btn.Name = "inventory_btn";
            this.inventory_btn.Size = new System.Drawing.Size(166, 45);
            this.inventory_btn.TabIndex = 6;
            this.inventory_btn.Text = "Inventory";
            this.inventory_btn.UseVisualStyleBackColor = false;
            this.inventory_btn.Click += new System.EventHandler(this.inventory_btn_Click);
            // 
            // shop_btn
            // 
            this.shop_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.shop_btn.FlatAppearance.BorderSize = 0;
            this.shop_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(130)))), ((int)(((byte)(98)))));
            this.shop_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(130)))), ((int)(((byte)(98)))));
            this.shop_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shop_btn.ForeColor = System.Drawing.Color.White;
            this.shop_btn.Location = new System.Drawing.Point(60, 270);
            this.shop_btn.Name = "shop_btn";
            this.shop_btn.Size = new System.Drawing.Size(166, 45);
            this.shop_btn.TabIndex = 5;
            this.shop_btn.Text = "Shop";
            this.shop_btn.UseVisualStyleBackColor = false;
            this.shop_btn.Click += new System.EventHandler(this.shop_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.dashboard_btn.FlatAppearance.BorderSize = 0;
            this.dashboard_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(130)))), ((int)(((byte)(98)))));
            this.dashboard_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(130)))), ((int)(((byte)(98)))));
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.ForeColor = System.Drawing.Color.White;
            this.dashboard_btn.Location = new System.Drawing.Point(59, 199);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(166, 45);
            this.dashboard_btn.TabIndex = 4;
            this.dashboard_btn.Text = "Dashboard";
            this.dashboard_btn.UseVisualStyleBackColor = false;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome Admin !";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.customersForm1);
            this.panel3.Controls.Add(this.categoryForm1);
            this.panel3.Controls.Add(this.inventoryForm1);
            this.panel3.Controls.Add(this.shopForm1);
            this.panel3.Controls.Add(this.dashboardForm1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(293, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(941, 767);
            this.panel3.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restaurant_Management_System.Properties.Resources.user1;
            this.pictureBox1.Location = new System.Drawing.Point(92, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // customersForm1
            // 
            this.customersForm1.Location = new System.Drawing.Point(0, 0);
            this.customersForm1.Name = "customersForm1";
            this.customersForm1.Size = new System.Drawing.Size(941, 767);
            this.customersForm1.TabIndex = 4;
            this.customersForm1.Load += new System.EventHandler(this.customersForm1_Load);
            // 
            // categoryForm1
            // 
            this.categoryForm1.Location = new System.Drawing.Point(0, 0);
            this.categoryForm1.Name = "categoryForm1";
            this.categoryForm1.Size = new System.Drawing.Size(941, 767);
            this.categoryForm1.TabIndex = 3;
            // 
            // inventoryForm1
            // 
            this.inventoryForm1.Location = new System.Drawing.Point(0, 0);
            this.inventoryForm1.Name = "inventoryForm1";
            this.inventoryForm1.Size = new System.Drawing.Size(941, 767);
            this.inventoryForm1.TabIndex = 2;
            this.inventoryForm1.Load += new System.EventHandler(this.inventoryForm1_Load);
            // 
            // shopForm1
            // 
            this.shopForm1.BackColor = System.Drawing.SystemColors.Control;
            this.shopForm1.Location = new System.Drawing.Point(0, 0);
            this.shopForm1.Name = "shopForm1";
            this.shopForm1.Size = new System.Drawing.Size(941, 767);
            this.shopForm1.TabIndex = 1;
            // 
            // dashboardForm1
            // 
            this.dashboardForm1.Location = new System.Drawing.Point(0, 0);
            this.dashboardForm1.Name = "dashboardForm1";
            this.dashboardForm1.Size = new System.Drawing.Size(941, 767);
            this.dashboardForm1.TabIndex = 0;
            this.dashboardForm1.Load += new System.EventHandler(this.dashboardForm1_Load);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 802);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Button customers_btn;
        private System.Windows.Forms.Button categories_btn;
        private System.Windows.Forms.Button inventory_btn;
        private System.Windows.Forms.Button shop_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Panel panel3;
        private dashboardForm dashboardForm1;
        private shopForm shopForm1;
        private inventoryForm inventoryForm1;
        private categoryForm categoryForm1;
        private customersForm customersForm1;
    }
}