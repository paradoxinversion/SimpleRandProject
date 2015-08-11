/*
 * Created by SharpDevelop.
 * User: Saboteur
 * Date: 7/28/2015
 * Time: 7:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SimpleRand
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ListBox categoryListBox;
		private System.Windows.Forms.Button randomizeButton;
		private System.Windows.Forms.RichTextBox optionsTextInput;
		private System.Windows.Forms.Button addCategoryButton;
		private System.Windows.Forms.TextBox categoryNameInput;
		private System.Windows.Forms.Button changeNameButton;
		private System.Windows.Forms.Button deleteCategoryButton;
		private System.Windows.Forms.Button saveDataButton;
		private System.Windows.Forms.RichTextBox outputTextBox;
		private System.Windows.Forms.Button clearOutputButton;
		private System.Windows.Forms.CheckBox editOutputCheckBox;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.categoryListBox = new System.Windows.Forms.ListBox();
			this.randomizeButton = new System.Windows.Forms.Button();
			this.addCategoryButton = new System.Windows.Forms.Button();
			this.categoryNameInput = new System.Windows.Forms.TextBox();
			this.changeNameButton = new System.Windows.Forms.Button();
			this.deleteCategoryButton = new System.Windows.Forms.Button();
			this.saveDataButton = new System.Windows.Forms.Button();
			this.clearOutputButton = new System.Windows.Forms.Button();
			this.editOutputCheckBox = new System.Windows.Forms.CheckBox();
			this.optionsTextInput = new System.Windows.Forms.RichTextBox();
			this.outputTextBox = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// categoryListBox
			// 
			this.categoryListBox.FormattingEnabled = true;
			this.categoryListBox.Location = new System.Drawing.Point(12, 12);
			this.categoryListBox.Name = "categoryListBox";
			this.categoryListBox.Size = new System.Drawing.Size(120, 147);
			this.categoryListBox.TabIndex = 0;
			this.categoryListBox.SelectedIndexChanged += new System.EventHandler(this.CategoryListBoxSelectedIndexChanged);
			// 
			// randomizeButton
			// 
			this.randomizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.randomizeButton.Enabled = false;
			this.randomizeButton.Location = new System.Drawing.Point(139, 309);
			this.randomizeButton.Name = "randomizeButton";
			this.randomizeButton.Size = new System.Drawing.Size(118, 23);
			this.randomizeButton.TabIndex = 3;
			this.randomizeButton.Text = "Pick Random Item";
			this.randomizeButton.UseVisualStyleBackColor = true;
			this.randomizeButton.Click += new System.EventHandler(this.RandomizeButtonClick);
			// 
			// addCategoryButton
			// 
			this.addCategoryButton.Location = new System.Drawing.Point(13, 164);
			this.addCategoryButton.Name = "addCategoryButton";
			this.addCategoryButton.Size = new System.Drawing.Size(119, 23);
			this.addCategoryButton.TabIndex = 5;
			this.addCategoryButton.Text = "Add Category";
			this.addCategoryButton.UseVisualStyleBackColor = true;
			this.addCategoryButton.Click += new System.EventHandler(this.AddCategoryButtonClick);
			// 
			// categoryNameInput
			// 
			this.categoryNameInput.Enabled = false;
			this.categoryNameInput.Location = new System.Drawing.Point(139, 13);
			this.categoryNameInput.Name = "categoryNameInput";
			this.categoryNameInput.Size = new System.Drawing.Size(166, 20);
			this.categoryNameInput.TabIndex = 6;
			// 
			// changeNameButton
			// 
			this.changeNameButton.Enabled = false;
			this.changeNameButton.Location = new System.Drawing.Point(312, 12);
			this.changeNameButton.Name = "changeNameButton";
			this.changeNameButton.Size = new System.Drawing.Size(85, 23);
			this.changeNameButton.TabIndex = 7;
			this.changeNameButton.Text = "Change Name";
			this.changeNameButton.UseVisualStyleBackColor = true;
			this.changeNameButton.Click += new System.EventHandler(this.ChangeNameButtonClick);
			// 
			// deleteCategoryButton
			// 
			this.deleteCategoryButton.Enabled = false;
			this.deleteCategoryButton.Location = new System.Drawing.Point(13, 193);
			this.deleteCategoryButton.Name = "deleteCategoryButton";
			this.deleteCategoryButton.Size = new System.Drawing.Size(119, 23);
			this.deleteCategoryButton.TabIndex = 8;
			this.deleteCategoryButton.Text = "Delete Category";
			this.deleteCategoryButton.UseVisualStyleBackColor = true;
			this.deleteCategoryButton.Click += new System.EventHandler(this.DeleteCategoryButtonClick);
			// 
			// saveDataButton
			// 
			this.saveDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.saveDataButton.Location = new System.Drawing.Point(490, 12);
			this.saveDataButton.Name = "saveDataButton";
			this.saveDataButton.Size = new System.Drawing.Size(75, 23);
			this.saveDataButton.TabIndex = 9;
			this.saveDataButton.Text = "Save Data";
			this.saveDataButton.UseVisualStyleBackColor = true;
			this.saveDataButton.Click += new System.EventHandler(this.SaveDataButtonClick);
			// 
			// clearOutputButton
			// 
			this.clearOutputButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.clearOutputButton.Location = new System.Drawing.Point(409, 310);
			this.clearOutputButton.Name = "clearOutputButton";
			this.clearOutputButton.Size = new System.Drawing.Size(75, 23);
			this.clearOutputButton.TabIndex = 11;
			this.clearOutputButton.Text = "Clear";
			this.clearOutputButton.UseVisualStyleBackColor = true;
			this.clearOutputButton.Click += new System.EventHandler(this.ClearOutputButtonClick);
			// 
			// editOutputCheckBox
			// 
			this.editOutputCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.editOutputCheckBox.Location = new System.Drawing.Point(490, 310);
			this.editOutputCheckBox.Name = "editOutputCheckBox";
			this.editOutputCheckBox.Size = new System.Drawing.Size(76, 24);
			this.editOutputCheckBox.TabIndex = 12;
			this.editOutputCheckBox.Text = "EditOutput";
			this.editOutputCheckBox.UseVisualStyleBackColor = true;
			this.editOutputCheckBox.CheckedChanged += new System.EventHandler(this.EditOutputCheckBoxCheckedChanged);
			// 
			// optionsTextInput
			// 
			this.optionsTextInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.optionsTextInput.Location = new System.Drawing.Point(139, 41);
			this.optionsTextInput.Name = "optionsTextInput";
			this.optionsTextInput.Size = new System.Drawing.Size(425, 120);
			this.optionsTextInput.TabIndex = 13;
			this.optionsTextInput.Text = "";
			this.optionsTextInput.TextChanged += new System.EventHandler(this.OptionsTextInputTextChanged);
			// 
			// outputTextBox
			// 
			this.outputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.outputTextBox.Location = new System.Drawing.Point(140, 167);
			this.outputTextBox.Name = "outputTextBox";
			this.outputTextBox.ReadOnly = true;
			this.outputTextBox.Size = new System.Drawing.Size(427, 137);
			this.outputTextBox.TabIndex = 14;
			this.outputTextBox.Text = "";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(579, 339);
			this.Controls.Add(this.outputTextBox);
			this.Controls.Add(this.optionsTextInput);
			this.Controls.Add(this.editOutputCheckBox);
			this.Controls.Add(this.clearOutputButton);
			this.Controls.Add(this.saveDataButton);
			this.Controls.Add(this.deleteCategoryButton);
			this.Controls.Add(this.changeNameButton);
			this.Controls.Add(this.categoryNameInput);
			this.Controls.Add(this.addCategoryButton);
			this.Controls.Add(this.randomizeButton);
			this.Controls.Add(this.categoryListBox);
			this.Name = "MainForm";
			this.Text = "SimpleRand";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
