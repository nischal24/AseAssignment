namespace assignment
{
    partial class Form1
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
            this.textarea = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.clear = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.command = new System.Windows.Forms.TextBox();
            this.run = new System.Windows.Forms.Button();
            this.textClear = new System.Windows.Forms.Button();
            this.Execute = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textarea
            // 
            this.textarea.Location = new System.Drawing.Point(29, 55);
            this.textarea.Multiline = true;
            this.textarea.Name = "textarea";
            this.textarea.Size = new System.Drawing.Size(284, 287);
            this.textarea.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.laveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // laveToolStripMenuItem
            // 
            this.laveToolStripMenuItem.Name = "laveToolStripMenuItem";
            this.laveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.laveToolStripMenuItem.Text = "Save";
            this.laveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(474, 55);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(302, 287);
            this.panel.TabIndex = 2;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(355, 179);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 3;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(355, 217);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 4;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // command
            // 
            this.command.Location = new System.Drawing.Point(474, 371);
            this.command.Name = "command";
            this.command.Size = new System.Drawing.Size(209, 20);
            this.command.TabIndex = 5;
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(689, 368);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(37, 23);
            this.run.TabIndex = 6;
            this.run.Text = "Run";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // textClear
            // 
            this.textClear.Location = new System.Drawing.Point(732, 368);
            this.textClear.Name = "textClear";
            this.textClear.Size = new System.Drawing.Size(44, 23);
            this.textClear.TabIndex = 7;
            this.textClear.Text = "Clear";
            this.textClear.UseVisualStyleBackColor = true;
            this.textClear.Click += new System.EventHandler(this.textClear_Click);
            // 
            // Execute
            // 
            this.Execute.Location = new System.Drawing.Point(169, 371);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(82, 23);
            this.Execute.TabIndex = 0;
            this.Execute.Text = "Execute";
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(250, 371);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(63, 23);
            this.refresh.TabIndex = 8;
            this.refresh.Text = "clear";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(34, 371);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(62, 23);
            this.load.TabIndex = 9;
            this.load.Text = "Load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(96, 371);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 10;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.save);
            this.Controls.Add(this.load);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.textClear);
            this.Controls.Add(this.run);
            this.Controls.Add(this.command);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.textarea);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textarea;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.TextBox command;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.Button textClear;
        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button save;
    }
}

