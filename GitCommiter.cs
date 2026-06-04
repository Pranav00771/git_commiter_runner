
namespace GitCommiter
{
    partial class GitCommiter
    {
       
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label owner, copy, dev;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.RichTextBox editor;
        private System.Windows.Forms.Label lab_r, lab_f;
        private System.Windows.Forms.TextBox text_r, text_f, text_u;
        private ButtonIDE commit_btn, clear_btn;
        

        private void InitGitCommiter()
        {
            this.Location = new System.Drawing.Point(0, 0);
            this.Size = new System.Drawing.Size(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.BackColor = System.Drawing.Color.FromArgb(0, 0, 0);
            this.Opacity = 0.7f;
            this.ShowIcon = true;
            this.Icon = (System.Drawing.Icon) global::GitCommiter.Properties.GitResource.Logo;
            this.Visible = true;
            


            this.close = new System.Windows.Forms.Label();
            this.close.Text = "x";
            this.close.Location = new System.Drawing.Point(this.Width - 70, 10);
            this.close.Size = new System.Drawing.Size(39, 39);
            this.close.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Arial", 11.0f, System.Drawing.FontStyle.Regular);
            this.close.MouseEnter += new System.EventHandler(close_MouseEnter);
            this.close.MouseLeave += new System.EventHandler(close_MouseLeave);
            this.close.Click += new System.EventHandler(close_Click);
            this.close.Visible = true;

            this.title = new System.Windows.Forms.Label();
            this.title.Text = "Copilot Git Commiter";
            this.title.Location = new System.Drawing.Point((this.Width - 400) / 2, 10);
            this.title.Size = new System.Drawing.Size(400, 39);
            this.title.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.title.Font = new System.Drawing.Font("Arial", 18.0f, System.Drawing.FontStyle.Bold);
            this.title.Visible = true;

            this.owner = new System.Windows.Forms.Label();
            this.owner.Text = "www.github.com";
            this.owner.Location = new System.Drawing.Point((this.Width - 300) / 2, this.Height - 90);
            this.owner.Size = new System.Drawing.Size(300, 20);
            this.owner.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.owner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.owner.Font = new System.Drawing.Font("Arial", 9.0f, System.Drawing.FontStyle.Regular);
            this.owner.MouseEnter += new System.EventHandler(owner_MouseEnter);
            this.owner.MouseLeave += new System.EventHandler(owner_MouseLeave);
            this.owner.Click += new System.EventHandler(owner_Click);
            this.owner.Visible = true;

            this.copy = new System.Windows.Forms.Label();
            this.copy.Text = "www.microsoft.com";
            this.copy.Location = new System.Drawing.Point((this.Width - 390) / 2 + 29 - 7, this.Height - 70);
            this.copy.Size = new System.Drawing.Size(390, 20);
            this.copy.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.copy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copy.Font = new System.Drawing.Font("Arial", 11.0f, System.Drawing.FontStyle.Regular);
            this.copy.MouseEnter += new System.EventHandler(copy_MouseEnter);
            this.copy.MouseLeave += new System.EventHandler(copy_MouseLeave);
            this.copy.Click += new System.EventHandler(copy_Click);
            this.copy.Visible = true;

            this.dev = new System.Windows.Forms.Label();
            this.dev.Text = "Developed by Pranav";
            this.dev.Location = new System.Drawing.Point((this.Width - 390) / 2 + 49, this.Height - 40);
            this.dev.Size = new System.Drawing.Size(390, 20);
            this.dev.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.dev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dev.Font = new System.Drawing.Font("Arial", 7.0f, System.Drawing.FontStyle.Regular);
            this.dev.Click += new System.EventHandler(dev_Click);
            this.dev.Visible = true;

            this.logo = new System.Windows.Forms.PictureBox();
            this.logo.Bounds = new System.Drawing.Rectangle(39, 29, 180, 180);
            this.logo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logo.BackColor = System.Drawing.Color.FromArgb(0, 0, 0);
            System.Drawing.Bitmap image = new System.Drawing.Bitmap((System.Drawing.Image)global::GitCommiter.Properties.GitResource.GitLogoSmall, 180, 180);
            this.logo.Image = image;
            this.logo.Visible = true;

            this.editor = new System.Windows.Forms.RichTextBox();
            this.editor.BackColor = System.Drawing.Color.FromArgb(0, 0, 0);
            this.editor.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.editor.Font = new System.Drawing.Font("Calibri", 11.0f, System.Drawing.FontStyle.Bold);
            this.editor.Bounds = new System.Drawing.Rectangle(239, 99, 900, 400);
            this.editor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.editor.SelectionColor = System.Drawing.Color.FromArgb(199, 0, 0);
            this.editor.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.editor.Visible = true;

            this.lab_r = new System.Windows.Forms.Label();
            this.lab_r.Text = "Repository:";
            this.lab_r.Font = new System.Drawing.Font("Calibri", 11.0f);
            this.lab_r.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.lab_r.Bounds = new System.Drawing.Rectangle(299, 511, 110, 20);
            this.lab_r.Visible = true;

            this.lab_f = new System.Windows.Forms.Label();
            this.lab_f.Text = "Filename:";
            this.lab_f.Font = new System.Drawing.Font("Calibri", 11.0f);
            this.lab_f.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.lab_f.Bounds = new System.Drawing.Rectangle(299, 539, 110, 20);
            this.lab_f.Visible = true;

            this.text_r = new System.Windows.Forms.TextBox();
            this.text_r.Bounds = new System.Drawing.Rectangle(499, 511, 338, 29);
            this.text_r.BackColor = System.Drawing.Color.FromArgb(29, 29, 29);
            this.text_r.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.text_r.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_r.Visible = true;


            this.text_f = new System.Windows.Forms.TextBox();
            this.text_f.Bounds = new System.Drawing.Rectangle(499, 539, 110, 29);
            this.text_f.BackColor = System.Drawing.Color.FromArgb(29, 29, 29);
            this.text_f.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.text_f.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_f.Visible = true;


            this.text_u = new System.Windows.Forms.TextBox();
            this.text_u.Bounds = new System.Drawing.Rectangle(899, 511, 110, 29);
            this.text_u.BackColor = System.Drawing.Color.FromArgb(29, 29, 29);
            this.text_u.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.text_u.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_u.Text = "Username GIT";
            this.text_u.Visible = true;


            this.clear_btn = new ButtonIDE("Clear");
            this.clear_btn.Bounds = new System.Drawing.Rectangle(649, 600, 90, 29);
            this.clear_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear_btn.Click += new System.EventHandler(clear_btn_Click);
            this.clear_btn.Visible = true;

            this.commit_btn = new ButtonIDE("Commit");
            this.commit_btn.Bounds = new System.Drawing.Rectangle(529, 600, 110, 29);
            this.commit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.commit_btn.Click += new System.EventHandler(commit_btn_Click);
            this.commit_btn.Visible = true;


            this.Controls.Add(this.close);
            this.Controls.Add(this.title);
            this.Controls.Add(this.owner);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.dev);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.editor);
            this.Controls.Add(this.lab_r);
            this.Controls.Add(this.lab_f);
            this.Controls.Add(this.text_r);
            this.Controls.Add(this.text_f);
            this.Controls.Add(this.text_u);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.commit_btn);



        }
        private void clear_btn_Click(object sender, System.EventArgs e)
        {
            if (editor.Text.Length > 0)
            {
                editor.Text = null;
            }
            if (text_r.Text.Length > 0)
            {
                text_r.Text = null;
            }
            if (text_f.Text.Length > 0)
            {
                text_f.Text = null;
            }
            if (text_u.Text.Length > 0)
            {
                text_u.Text = null;
            }
        
        }

        private void commit_btn_Click(object sender, System.EventArgs e)
        {
            if (editor.Text.Length > 0 && text_r.Text.Length > 0 && text_f.Text.Length > 0 && text_r.Text.Length > 0)
            {
                if (text_f.Text.Contains("."))
                {
                    try
                    
                    {
                        commit_btn.setText("Commiting..");
                        string cmd=@"git remote add copilot https://github.com/"+text_u.Text+"/"+text_r.Text+".git\n"+"git init\n"+"git add "+text_f.Text+"\n"+"git commit -m \"Added a file.\""+"\n"+"git push -f copilot master\n"+"git remote remove copilot\n";
                        System.IO.File.WriteAllText(text_f.Text, editor.Text);
                         System.IO.File.WriteAllText("task.bat", cmd);
                        System.Diagnostics.Process.Start("task.bat");
                        System.Threading.Thread.Sleep(100);
                        System.IO.File.Delete(text_f.Text);
                        System.IO.File.Delete("task.bat");
                        commit_btn.setText("Commit");

                       
                    }
                    catch (System.Exception exp)
                    {
                       System.Windows.Forms.MessageBox.Show(exp.Message, "Error");
                    }

                }
               
            }
        }

    }

}
