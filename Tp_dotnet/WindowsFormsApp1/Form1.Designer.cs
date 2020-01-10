namespace WindowsFormsApp1
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
            this.Ajouter = new System.Windows.Forms.Button();
            this.Current_Element = new System.Windows.Forms.Button();
            this.Current_index = new System.Windows.Forms.Button();
            this.Check_selection = new System.Windows.Forms.Button();
            this.Delete_element = new System.Windows.Forms.Button();
            this.Empty_list = new System.Windows.Forms.Button();
            this.Check_existance = new System.Windows.Forms.Button();
            this.Quitter = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.user_input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(642, 78);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(75, 23);
            this.Ajouter.TabIndex = 0;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // Current_Element
            // 
            this.Current_Element.Location = new System.Drawing.Point(533, 116);
            this.Current_Element.Name = "Current_Element";
            this.Current_Element.Size = new System.Drawing.Size(184, 23);
            this.Current_Element.TabIndex = 1;
            this.Current_Element.Text = "Element en cours";
            this.Current_Element.UseVisualStyleBackColor = true;
            this.Current_Element.Click += new System.EventHandler(this.Current_Element_Click);
            // 
            // Current_index
            // 
            this.Current_index.Location = new System.Drawing.Point(527, 163);
            this.Current_index.Name = "Current_index";
            this.Current_index.Size = new System.Drawing.Size(190, 23);
            this.Current_index.TabIndex = 2;
            this.Current_index.Text = "Indice de l\'élement en cour";
            this.Current_index.UseVisualStyleBackColor = true;
            this.Current_index.Click += new System.EventHandler(this.Current_index_Click);
            // 
            // Check_selection
            // 
            this.Check_selection.Location = new System.Drawing.Point(527, 209);
            this.Check_selection.Name = "Check_selection";
            this.Check_selection.Size = new System.Drawing.Size(190, 23);
            this.Check_selection.TabIndex = 3;
            this.Check_selection.Text = "Verfication de l\'element selectionné";
            this.Check_selection.UseVisualStyleBackColor = true;
            this.Check_selection.Click += new System.EventHandler(this.Check_selection_Click);
            // 
            // Delete_element
            // 
            this.Delete_element.Location = new System.Drawing.Point(527, 264);
            this.Delete_element.Name = "Delete_element";
            this.Delete_element.Size = new System.Drawing.Size(190, 23);
            this.Delete_element.TabIndex = 4;
            this.Delete_element.Text = "Supprimer un élément";
            this.Delete_element.UseVisualStyleBackColor = true;
            this.Delete_element.Click += new System.EventHandler(this.Delete_element_Click);
            // 
            // Empty_list
            // 
            this.Empty_list.Location = new System.Drawing.Point(527, 312);
            this.Empty_list.Name = "Empty_list";
            this.Empty_list.Size = new System.Drawing.Size(190, 23);
            this.Empty_list.TabIndex = 5;
            this.Empty_list.Text = "Vider liste";
            this.Empty_list.UseVisualStyleBackColor = true;
            this.Empty_list.Click += new System.EventHandler(this.Empty_list_Click);
            // 
            // Check_existance
            // 
            this.Check_existance.Location = new System.Drawing.Point(527, 360);
            this.Check_existance.Name = "Check_existance";
            this.Check_existance.Size = new System.Drawing.Size(190, 23);
            this.Check_existance.TabIndex = 6;
            this.Check_existance.Text = "Verifier si existe";
            this.Check_existance.UseVisualStyleBackColor = true;
            this.Check_existance.Click += new System.EventHandler(this.Check_existance_Click);
            // 
            // Quitter
            // 
            this.Quitter.Location = new System.Drawing.Point(652, 436);
            this.Quitter.Name = "Quitter";
            this.Quitter.Size = new System.Drawing.Size(75, 23);
            this.Quitter.TabIndex = 7;
            this.Quitter.Text = "Quitter";
            this.Quitter.UseVisualStyleBackColor = true;
            this.Quitter.Click += new System.EventHandler(this.Quitter_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(110, 78);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(207, 381);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // user_input
            // 
            this.user_input.Location = new System.Drawing.Point(349, 78);
            this.user_input.Name = "user_input";
            this.user_input.Size = new System.Drawing.Size(172, 20);
            this.user_input.TabIndex = 9;
            this.user_input.TextChanged += new System.EventHandler(this.user_input_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 595);
            this.Controls.Add(this.user_input);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Quitter);
            this.Controls.Add(this.Check_existance);
            this.Controls.Add(this.Empty_list);
            this.Controls.Add(this.Delete_element);
            this.Controls.Add(this.Check_selection);
            this.Controls.Add(this.Current_index);
            this.Controls.Add(this.Current_Element);
            this.Controls.Add(this.Ajouter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Current_Element;
        private System.Windows.Forms.Button Current_index;
        private System.Windows.Forms.Button Check_selection;
        private System.Windows.Forms.Button Delete_element;
        private System.Windows.Forms.Button Empty_list;
        private System.Windows.Forms.Button Check_existance;
        private System.Windows.Forms.Button Quitter;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox user_input;
    }
}

