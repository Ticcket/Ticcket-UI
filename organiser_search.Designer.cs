
namespace Ticcket
{
    partial class organiser_search
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bTnDesign1 = new Ticcket.Resources.BTnDesign();
            this.bTnDesign4 = new Ticcket.Resources.BTnDesign();
            this.Search = new Ticcket.Resources.BTnDesign();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bTnDesign1
            // 
            this.bTnDesign1.BackColor = System.Drawing.Color.White;
            this.bTnDesign1.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.bTnDesign1.BorderRadius = 40;
            this.bTnDesign1.BorderSize = 1;
            this.bTnDesign1.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.bTnDesign1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bTnDesign1.ForeColor = System.Drawing.Color.White;
            this.bTnDesign1.Location = new System.Drawing.Point(35, 15);
            this.bTnDesign1.Name = "bTnDesign1";
            this.bTnDesign1.Size = new System.Drawing.Size(503, 40);
            this.bTnDesign1.TabIndex = 1;
            this.bTnDesign1.Text = "bTnDesign1";
            this.bTnDesign1.TextColor = System.Drawing.Color.White;
            this.bTnDesign1.UseVisualStyleBackColor = false;
            // 
            // bTnDesign4
            // 
            this.bTnDesign4.BackColor = System.Drawing.Color.White;
            this.bTnDesign4.BorderColor = System.Drawing.Color.Navy;
            this.bTnDesign4.BorderRadius = 40;
            this.bTnDesign4.BorderSize = 2;
            this.bTnDesign4.Cursor = System.Windows.Forms.Cursors.Default;
            this.bTnDesign4.FlatAppearance.BorderSize = 2;
            this.bTnDesign4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTnDesign4.Font = new System.Drawing.Font("Urdu Typesetting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTnDesign4.ForeColor = System.Drawing.Color.White;
            this.bTnDesign4.Location = new System.Drawing.Point(68, 8);
            this.bTnDesign4.Name = "bTnDesign4";
            this.bTnDesign4.Size = new System.Drawing.Size(495, 50);
            this.bTnDesign4.TabIndex = 33;
            this.bTnDesign4.TextColor = System.Drawing.Color.White;
            this.bTnDesign4.UseVisualStyleBackColor = false;
            this.bTnDesign4.Click += new System.EventHandler(this.bTnDesign4_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.White;
            this.Search.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.Search.BorderRadius = 40;
            this.Search.BorderSize = 1;
            this.Search.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.Location = new System.Drawing.Point(79, 7);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(490, 51);
            this.Search.TabIndex = 36;
            this.Search.TextColor = System.Drawing.Color.White;
            this.Search.UseVisualStyleBackColor = false;
            // 
            // textSearch
            // 
            this.textSearch.BackColor = System.Drawing.Color.White;
            this.textSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSearch.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F);
            this.textSearch.Location = new System.Drawing.Point(122, 18);
            this.textSearch.Multiline = true;
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(435, 29);
            this.textSearch.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(86, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 29);
            this.label3.TabIndex = 38;
            this.label3.Text = "🔍 ";
            // 
            // organiser_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Search);
            this.Name = "organiser_search";
            this.Size = new System.Drawing.Size(616, 362);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Resources.BTnDesign bTnDesign1;
        private Resources.BTnDesign bTnDesign4;
        private Resources.BTnDesign Search;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Label label3;
    }
}
