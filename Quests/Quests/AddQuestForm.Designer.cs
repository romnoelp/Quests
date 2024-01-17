using System.ComponentModel;

namespace Quests
{
    partial class AddQuestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.questLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.questCategory = new System.Windows.Forms.ComboBox();
            this.addQuest = new System.Windows.Forms.Button();
            this.questString = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(23, 23);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(23, 23);
            this.toolStripDropDownButton2.Text = "toolStripDropDownButton2";
            // 
            // questLabel
            // 
            this.questLabel.Font = new System.Drawing.Font("Minecraft", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questLabel.Location = new System.Drawing.Point(-1, -2);
            this.questLabel.Name = "questLabel";
            this.questLabel.Size = new System.Drawing.Size(55, 40);
            this.questLabel.TabIndex = 0;
            this.questLabel.Text = "Quest:";
            this.questLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // categoryLabel
            // 
            this.categoryLabel.Font = new System.Drawing.Font("Minecraft", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.Location = new System.Drawing.Point(195, -2);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(93, 40);
            this.categoryLabel.TabIndex = 2;
            this.categoryLabel.Text = "Category:";
            this.categoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // questCategory
            // 
            this.questCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.questCategory.Font = new System.Drawing.Font("Minecraft", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questCategory.FormattingEnabled = true;
            this.questCategory.Items.AddRange(new object[] { "Programming", "Game Dev", "Minor ", "Workout" });
            this.questCategory.Location = new System.Drawing.Point(283, 9);
            this.questCategory.Name = "questCategory";
            this.questCategory.Size = new System.Drawing.Size(132, 21);
            this.questCategory.TabIndex = 3;
            // 
            // addQuest
            // 
            this.addQuest.Font = new System.Drawing.Font("Minecraft", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuest.Location = new System.Drawing.Point(135, 41);
            this.addQuest.Name = "addQuest";
            this.addQuest.Size = new System.Drawing.Size(153, 33);
            this.addQuest.TabIndex = 4;
            this.addQuest.Text = "Add quest!";
            this.addQuest.UseVisualStyleBackColor = true;
            this.addQuest.Click += new System.EventHandler(this.addQuest_Click);
            // 
            // questString
            // 
            this.questString.Font = new System.Drawing.Font("Minecraft", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questString.Location = new System.Drawing.Point(60, 9);
            this.questString.Name = "questString";
            this.questString.Size = new System.Drawing.Size(125, 21);
            this.questString.TabIndex = 1;
            // 
            // AddQuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 82);
            this.Controls.Add(this.addQuest);
            this.Controls.Add(this.questCategory);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.questString);
            this.Controls.Add(this.questLabel);
            this.Name = "AddQuestForm";
            this.Text = "AddQuestForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button addQuest;

        private System.Windows.Forms.Label questLabel;
        private System.Windows.Forms.TextBox questString;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.ComboBox questCategory;

        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;

        #endregion
    }
}