namespace calculadora

partial class MainForm(System.Windows.Forms.Form):
	private components as System.ComponentModel.IContainer = null
	
	protected override def Dispose(disposing as bool) as void:
		if disposing:
			if components is not null:
				components.Dispose()
		super(disposing)
	
	// This method is required for Windows Forms designer support.
	// Do not change the method contents inside the source code editor. The Forms designer might
	// not be able to load this method if it was changed manually.
	private def InitializeComponent():
		self.button1 = System.Windows.Forms.Button()
		self.SuspendLayout()
		# 
		# button1
		# 
		self.button1.Location = System.Drawing.Point(95, 48)
		self.button1.Name = "button1"
		self.button1.Size = System.Drawing.Size(75, 23)
		self.button1.TabIndex = 0
		self.button1.Text = "button1"
		self.button1.UseVisualStyleBackColor = true
		self.button1.Click += self.Button1Click as System.EventHandler
		# 
		# MainForm
		# 
		self.AutoScaleDimensions = System.Drawing.SizeF(6, 13)
		self.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		self.ClientSize = System.Drawing.Size(284, 261)
		self.Controls.Add(self.button1)
		self.Name = "MainForm"
		self.Text = "MainForm"
		self.ResumeLayout(false)
	private button1 as System.Windows.Forms.Button

