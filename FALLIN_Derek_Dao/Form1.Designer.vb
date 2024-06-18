<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFallin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpMain = New System.Windows.Forms.GroupBox()
        Me.rdbLaser = New System.Windows.Forms.RadioButton()
        Me.rdbBow = New System.Windows.Forms.RadioButton()
        Me.rdbTwoHand = New System.Windows.Forms.RadioButton()
        Me.rdbSword = New System.Windows.Forms.RadioButton()
        Me.rdbClub = New System.Windows.Forms.RadioButton()
        Me.grpSecondary = New System.Windows.Forms.GroupBox()
        Me.chkBatteries = New System.Windows.Forms.CheckBox()
        Me.chkLute = New System.Windows.Forms.CheckBox()
        Me.chkPerfume = New System.Windows.Forms.CheckBox()
        Me.chkArrows = New System.Windows.Forms.CheckBox()
        Me.chkHeavy = New System.Windows.Forms.CheckBox()
        Me.chkHelmet = New System.Windows.Forms.CheckBox()
        Me.chkShield = New System.Windows.Forms.CheckBox()
        Me.chkWater = New System.Windows.Forms.CheckBox()
        Me.chkFood = New System.Windows.Forms.CheckBox()
        Me.btnQuartermaster = New System.Windows.Forms.Button()
        Me.btnOracle = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpCharacter = New System.Windows.Forms.GroupBox()
        Me.picPerson = New System.Windows.Forms.PictureBox()
        Me.grpTester = New System.Windows.Forms.GroupBox()
        Me.lblText = New System.Windows.Forms.Label()
        Me.lblLids = New System.Windows.Forms.Label()
        Me.lblLidsSpent = New System.Windows.Forms.Label()
        Me.lblSurvivalRating = New System.Windows.Forms.Label()
        Me.lblSR = New System.Windows.Forms.Label()
        Me.lblRandomNumber = New System.Windows.Forms.Label()
        Me.lblRandom = New System.Windows.Forms.Label()
        Me.lblRemaining = New System.Windows.Forms.Label()
        Me.lblSpentTotal = New System.Windows.Forms.Label()
        Me.lblRemain = New System.Windows.Forms.Label()
        Me.lblSpent = New System.Windows.Forms.Label()
        Me.grpMain.SuspendLayout()
        Me.grpSecondary.SuspendLayout()
        Me.grpCharacter.SuspendLayout()
        CType(Me.picPerson, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTester.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpMain
        '
        Me.grpMain.BackgroundImage = Global.FALLIN_Derek_Dao.My.Resources.Resources.Best_Pip_Boy_Wallpaper_Free_Wallpaper_For_Desktop_and_Mobile_in_All_Resolutions_Free_Download_sofa_sectionals_with_chaise_lounge
        Me.grpMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.grpMain.Controls.Add(Me.rdbLaser)
        Me.grpMain.Controls.Add(Me.rdbBow)
        Me.grpMain.Controls.Add(Me.rdbTwoHand)
        Me.grpMain.Controls.Add(Me.rdbSword)
        Me.grpMain.Controls.Add(Me.rdbClub)
        Me.grpMain.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMain.ForeColor = System.Drawing.Color.White
        Me.grpMain.Location = New System.Drawing.Point(12, 12)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(190, 144)
        Me.grpMain.TabIndex = 0
        Me.grpMain.TabStop = False
        Me.grpMain.Text = "Primary Weapons (Choose One)"
        '
        'rdbLaser
        '
        Me.rdbLaser.AutoSize = True
        Me.rdbLaser.BackColor = System.Drawing.Color.Transparent
        Me.rdbLaser.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbLaser.Location = New System.Drawing.Point(17, 120)
        Me.rdbLaser.Name = "rdbLaser"
        Me.rdbLaser.Size = New System.Drawing.Size(170, 16)
        Me.rdbLaser.TabIndex = 4
        Me.rdbLaser.Text = "Laser (3 Bolts) (100)"
        Me.rdbLaser.UseVisualStyleBackColor = False
        '
        'rdbBow
        '
        Me.rdbBow.AutoSize = True
        Me.rdbBow.BackColor = System.Drawing.Color.Transparent
        Me.rdbBow.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbBow.Location = New System.Drawing.Point(17, 99)
        Me.rdbBow.Name = "rdbBow"
        Me.rdbBow.Size = New System.Drawing.Size(163, 16)
        Me.rdbBow.TabIndex = 3
        Me.rdbBow.Text = "Bow (No Arrows) (40)"
        Me.rdbBow.UseVisualStyleBackColor = False
        '
        'rdbTwoHand
        '
        Me.rdbTwoHand.AutoSize = True
        Me.rdbTwoHand.BackColor = System.Drawing.Color.Transparent
        Me.rdbTwoHand.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbTwoHand.Location = New System.Drawing.Point(17, 78)
        Me.rdbTwoHand.Name = "rdbTwoHand"
        Me.rdbTwoHand.Size = New System.Drawing.Size(156, 16)
        Me.rdbTwoHand.TabIndex = 2
        Me.rdbTwoHand.Text = "Two Hand Sword (40)"
        Me.rdbTwoHand.UseVisualStyleBackColor = False
        '
        'rdbSword
        '
        Me.rdbSword.AutoSize = True
        Me.rdbSword.BackColor = System.Drawing.Color.Transparent
        Me.rdbSword.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbSword.Location = New System.Drawing.Point(17, 57)
        Me.rdbSword.Name = "rdbSword"
        Me.rdbSword.Size = New System.Drawing.Size(93, 16)
        Me.rdbSword.TabIndex = 1
        Me.rdbSword.Text = "Sword (50)"
        Me.rdbSword.UseVisualStyleBackColor = False
        '
        'rdbClub
        '
        Me.rdbClub.AutoSize = True
        Me.rdbClub.BackColor = System.Drawing.Color.Transparent
        Me.rdbClub.Checked = True
        Me.rdbClub.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbClub.Location = New System.Drawing.Point(17, 36)
        Me.rdbClub.Name = "rdbClub"
        Me.rdbClub.Size = New System.Drawing.Size(79, 16)
        Me.rdbClub.TabIndex = 0
        Me.rdbClub.TabStop = True
        Me.rdbClub.Text = "Club (0)"
        Me.rdbClub.UseVisualStyleBackColor = False
        '
        'grpSecondary
        '
        Me.grpSecondary.BackgroundImage = Global.FALLIN_Derek_Dao.My.Resources.Resources.Best_Pip_Boy_Wallpaper_Free_Wallpaper_For_Desktop_and_Mobile_in_All_Resolutions_Free_Download_sofa_sectionals_with_chaise_lounge
        Me.grpSecondary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.grpSecondary.Controls.Add(Me.chkBatteries)
        Me.grpSecondary.Controls.Add(Me.chkLute)
        Me.grpSecondary.Controls.Add(Me.chkPerfume)
        Me.grpSecondary.Controls.Add(Me.chkArrows)
        Me.grpSecondary.Controls.Add(Me.chkHeavy)
        Me.grpSecondary.Controls.Add(Me.chkHelmet)
        Me.grpSecondary.Controls.Add(Me.chkShield)
        Me.grpSecondary.Controls.Add(Me.chkWater)
        Me.grpSecondary.Controls.Add(Me.chkFood)
        Me.grpSecondary.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSecondary.ForeColor = System.Drawing.Color.White
        Me.grpSecondary.Location = New System.Drawing.Point(12, 180)
        Me.grpSecondary.Name = "grpSecondary"
        Me.grpSecondary.Size = New System.Drawing.Size(300, 159)
        Me.grpSecondary.TabIndex = 1
        Me.grpSecondary.TabStop = False
        Me.grpSecondary.Text = "Secondary Items"
        '
        'chkBatteries
        '
        Me.chkBatteries.AutoSize = True
        Me.chkBatteries.BackColor = System.Drawing.Color.Transparent
        Me.chkBatteries.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBatteries.Location = New System.Drawing.Point(163, 99)
        Me.chkBatteries.Name = "chkBatteries"
        Me.chkBatteries.Size = New System.Drawing.Size(136, 40)
        Me.chkBatteries.TabIndex = 8
        Me.chkBatteries.Text = "Additional " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Laser Batteries " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(10)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.chkBatteries.UseVisualStyleBackColor = False
        '
        'chkLute
        '
        Me.chkLute.AutoSize = True
        Me.chkLute.BackColor = System.Drawing.Color.Transparent
        Me.chkLute.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLute.Location = New System.Drawing.Point(163, 74)
        Me.chkLute.Name = "chkLute"
        Me.chkLute.Size = New System.Drawing.Size(87, 16)
        Me.chkLute.TabIndex = 7
        Me.chkLute.Text = "Lute (40)"
        Me.chkLute.UseVisualStyleBackColor = False
        '
        'chkPerfume
        '
        Me.chkPerfume.AutoSize = True
        Me.chkPerfume.BackColor = System.Drawing.Color.Transparent
        Me.chkPerfume.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPerfume.Location = New System.Drawing.Point(163, 49)
        Me.chkPerfume.Name = "chkPerfume"
        Me.chkPerfume.Size = New System.Drawing.Size(108, 16)
        Me.chkPerfume.TabIndex = 6
        Me.chkPerfume.Text = "Perfume (10)"
        Me.chkPerfume.UseVisualStyleBackColor = False
        '
        'chkArrows
        '
        Me.chkArrows.AutoSize = True
        Me.chkArrows.BackColor = System.Drawing.Color.Transparent
        Me.chkArrows.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkArrows.Location = New System.Drawing.Point(163, 24)
        Me.chkArrows.Name = "chkArrows"
        Me.chkArrows.Size = New System.Drawing.Size(101, 16)
        Me.chkArrows.TabIndex = 5
        Me.chkArrows.Text = "Arrows (20)"
        Me.chkArrows.UseVisualStyleBackColor = False
        '
        'chkHeavy
        '
        Me.chkHeavy.AutoSize = True
        Me.chkHeavy.BackColor = System.Drawing.Color.Transparent
        Me.chkHeavy.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkHeavy.Location = New System.Drawing.Point(17, 124)
        Me.chkHeavy.Name = "chkHeavy"
        Me.chkHeavy.Size = New System.Drawing.Size(143, 16)
        Me.chkHeavy.TabIndex = 4
        Me.chkHeavy.Text = "Heavy Gloves (20)"
        Me.chkHeavy.UseVisualStyleBackColor = False
        '
        'chkHelmet
        '
        Me.chkHelmet.AutoSize = True
        Me.chkHelmet.BackColor = System.Drawing.Color.Transparent
        Me.chkHelmet.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkHelmet.Location = New System.Drawing.Point(17, 99)
        Me.chkHelmet.Name = "chkHelmet"
        Me.chkHelmet.Size = New System.Drawing.Size(101, 16)
        Me.chkHelmet.TabIndex = 3
        Me.chkHelmet.Text = "Helmet (30)"
        Me.chkHelmet.UseVisualStyleBackColor = False
        '
        'chkShield
        '
        Me.chkShield.AutoSize = True
        Me.chkShield.BackColor = System.Drawing.Color.Transparent
        Me.chkShield.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShield.Location = New System.Drawing.Point(17, 74)
        Me.chkShield.Name = "chkShield"
        Me.chkShield.Size = New System.Drawing.Size(101, 16)
        Me.chkShield.TabIndex = 2
        Me.chkShield.Text = "Shield (40)"
        Me.chkShield.UseVisualStyleBackColor = False
        '
        'chkWater
        '
        Me.chkWater.AutoSize = True
        Me.chkWater.BackColor = System.Drawing.Color.Transparent
        Me.chkWater.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkWater.Location = New System.Drawing.Point(17, 49)
        Me.chkWater.Name = "chkWater"
        Me.chkWater.Size = New System.Drawing.Size(94, 16)
        Me.chkWater.TabIndex = 1
        Me.chkWater.Text = "Water (60)"
        Me.chkWater.UseVisualStyleBackColor = False
        '
        'chkFood
        '
        Me.chkFood.AutoSize = True
        Me.chkFood.BackColor = System.Drawing.Color.Transparent
        Me.chkFood.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFood.Location = New System.Drawing.Point(17, 24)
        Me.chkFood.Name = "chkFood"
        Me.chkFood.Size = New System.Drawing.Size(87, 16)
        Me.chkFood.TabIndex = 0
        Me.chkFood.Text = "Food (50)"
        Me.chkFood.UseVisualStyleBackColor = False
        '
        'btnQuartermaster
        '
        Me.btnQuartermaster.BackgroundImage = Global.FALLIN_Derek_Dao.My.Resources.Resources.ezgif_4_cfe39930c716
        Me.btnQuartermaster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnQuartermaster.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuartermaster.ForeColor = System.Drawing.Color.White
        Me.btnQuartermaster.Location = New System.Drawing.Point(12, 358)
        Me.btnQuartermaster.Name = "btnQuartermaster"
        Me.btnQuartermaster.Size = New System.Drawing.Size(145, 132)
        Me.btnQuartermaster.TabIndex = 2
        Me.btnQuartermaster.Text = "Quartermaster Check"
        Me.btnQuartermaster.UseVisualStyleBackColor = True
        '
        'btnOracle
        '
        Me.btnOracle.BackgroundImage = Global.FALLIN_Derek_Dao.My.Resources.Resources.ezgif_com_crop
        Me.btnOracle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOracle.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOracle.ForeColor = System.Drawing.Color.White
        Me.btnOracle.Location = New System.Drawing.Point(188, 358)
        Me.btnOracle.Name = "btnOracle"
        Me.btnOracle.Size = New System.Drawing.Size(143, 132)
        Me.btnOracle.TabIndex = 3
        Me.btnOracle.Text = "Oracle Visit"
        Me.btnOracle.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.BackgroundImage = Global.FALLIN_Derek_Dao.My.Resources.Resources.Best_Pip_Boy_Wallpaper_Free_Wallpaper_For_Desktop_and_Mobile_in_All_Resolutions_Free_Download_sofa_sectionals_with_chaise_lounge
        Me.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReset.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(12, 505)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(145, 127)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "Start Over"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.BackgroundImage = Global.FALLIN_Derek_Dao.My.Resources.Resources.Best_Pip_Boy_Wallpaper_Free_Wallpaper_For_Desktop_and_Mobile_in_All_Resolutions_Free_Download_sofa_sectionals_with_chaise_lounge
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExit.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(188, 505)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(141, 126)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'grpCharacter
        '
        Me.grpCharacter.BackgroundImage = Global.FALLIN_Derek_Dao.My.Resources.Resources.lg
        Me.grpCharacter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.grpCharacter.Controls.Add(Me.lblText)
        Me.grpCharacter.Controls.Add(Me.picPerson)
        Me.grpCharacter.ForeColor = System.Drawing.Color.White
        Me.grpCharacter.Location = New System.Drawing.Point(318, 33)
        Me.grpCharacter.Name = "grpCharacter"
        Me.grpCharacter.Size = New System.Drawing.Size(364, 187)
        Me.grpCharacter.TabIndex = 6
        Me.grpCharacter.TabStop = False
        '
        'picPerson
        '
        Me.picPerson.Location = New System.Drawing.Point(207, 19)
        Me.picPerson.Name = "picPerson"
        Me.picPerson.Size = New System.Drawing.Size(151, 162)
        Me.picPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPerson.TabIndex = 0
        Me.picPerson.TabStop = False
        '
        'grpTester
        '
        Me.grpTester.BackgroundImage = Global.FALLIN_Derek_Dao.My.Resources.Resources.Best_Pip_Boy_Wallpaper_Free_Wallpaper_For_Desktop_and_Mobile_in_All_Resolutions_Free_Download_sofa_sectionals_with_chaise_lounge
        Me.grpTester.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.grpTester.Controls.Add(Me.lblRandom)
        Me.grpTester.Controls.Add(Me.lblRandomNumber)
        Me.grpTester.Controls.Add(Me.lblSR)
        Me.grpTester.Controls.Add(Me.lblSurvivalRating)
        Me.grpTester.Controls.Add(Me.lblLidsSpent)
        Me.grpTester.Controls.Add(Me.lblLids)
        Me.grpTester.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTester.ForeColor = System.Drawing.Color.White
        Me.grpTester.Location = New System.Drawing.Point(399, 358)
        Me.grpTester.Name = "grpTester"
        Me.grpTester.Size = New System.Drawing.Size(215, 107)
        Me.grpTester.TabIndex = 7
        Me.grpTester.TabStop = False
        Me.grpTester.Text = "Tester's Display"
        '
        'lblText
        '
        Me.lblText.AutoSize = True
        Me.lblText.BackColor = System.Drawing.Color.Transparent
        Me.lblText.Location = New System.Drawing.Point(6, 39)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(25, 13)
        Me.lblText.TabIndex = 1
        Me.lblText.Text = "___"
        '
        'lblLids
        '
        Me.lblLids.AutoSize = True
        Me.lblLids.BackColor = System.Drawing.Color.Transparent
        Me.lblLids.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLids.Location = New System.Drawing.Point(154, 30)
        Me.lblLids.Name = "lblLids"
        Me.lblLids.Size = New System.Drawing.Size(26, 12)
        Me.lblLids.TabIndex = 0
        Me.lblLids.Text = "___"
        '
        'lblLidsSpent
        '
        Me.lblLidsSpent.AutoSize = True
        Me.lblLidsSpent.BackColor = System.Drawing.Color.Transparent
        Me.lblLidsSpent.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLidsSpent.Location = New System.Drawing.Point(19, 30)
        Me.lblLidsSpent.Name = "lblLidsSpent"
        Me.lblLidsSpent.Size = New System.Drawing.Size(82, 12)
        Me.lblLidsSpent.TabIndex = 1
        Me.lblLidsSpent.Text = "Lids Spent:"
        '
        'lblSurvivalRating
        '
        Me.lblSurvivalRating.AutoSize = True
        Me.lblSurvivalRating.BackColor = System.Drawing.Color.Transparent
        Me.lblSurvivalRating.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurvivalRating.Location = New System.Drawing.Point(19, 54)
        Me.lblSurvivalRating.Name = "lblSurvivalRating"
        Me.lblSurvivalRating.Size = New System.Drawing.Size(117, 12)
        Me.lblSurvivalRating.TabIndex = 2
        Me.lblSurvivalRating.Text = "Survival Rating:"
        '
        'lblSR
        '
        Me.lblSR.AutoSize = True
        Me.lblSR.BackColor = System.Drawing.Color.Transparent
        Me.lblSR.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSR.Location = New System.Drawing.Point(154, 54)
        Me.lblSR.Name = "lblSR"
        Me.lblSR.Size = New System.Drawing.Size(26, 12)
        Me.lblSR.TabIndex = 3
        Me.lblSR.Text = "___"
        '
        'lblRandomNumber
        '
        Me.lblRandomNumber.AutoSize = True
        Me.lblRandomNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblRandomNumber.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRandomNumber.Location = New System.Drawing.Point(19, 77)
        Me.lblRandomNumber.Name = "lblRandomNumber"
        Me.lblRandomNumber.Size = New System.Drawing.Size(103, 12)
        Me.lblRandomNumber.TabIndex = 4
        Me.lblRandomNumber.Text = "Random Number:"
        '
        'lblRandom
        '
        Me.lblRandom.AutoSize = True
        Me.lblRandom.BackColor = System.Drawing.Color.Transparent
        Me.lblRandom.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRandom.Location = New System.Drawing.Point(154, 77)
        Me.lblRandom.Name = "lblRandom"
        Me.lblRandom.Size = New System.Drawing.Size(26, 12)
        Me.lblRandom.TabIndex = 5
        Me.lblRandom.Text = "___"
        '
        'lblRemaining
        '
        Me.lblRemaining.AutoSize = True
        Me.lblRemaining.BackColor = System.Drawing.Color.Transparent
        Me.lblRemaining.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemaining.ForeColor = System.Drawing.Color.White
        Me.lblRemaining.Location = New System.Drawing.Point(319, 9)
        Me.lblRemaining.Name = "lblRemaining"
        Me.lblRemaining.Size = New System.Drawing.Size(142, 15)
        Me.lblRemaining.TabIndex = 8
        Me.lblRemaining.Text = "Lids Remaining:"
        '
        'lblSpentTotal
        '
        Me.lblSpentTotal.AutoSize = True
        Me.lblSpentTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblSpentTotal.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpentTotal.ForeColor = System.Drawing.Color.White
        Me.lblSpentTotal.Location = New System.Drawing.Point(508, 9)
        Me.lblSpentTotal.Name = "lblSpentTotal"
        Me.lblSpentTotal.Size = New System.Drawing.Size(106, 15)
        Me.lblSpentTotal.TabIndex = 9
        Me.lblSpentTotal.Text = "Lids Spent:"
        '
        'lblRemain
        '
        Me.lblRemain.AutoSize = True
        Me.lblRemain.BackColor = System.Drawing.Color.Transparent
        Me.lblRemain.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemain.ForeColor = System.Drawing.Color.White
        Me.lblRemain.Location = New System.Drawing.Point(467, 9)
        Me.lblRemain.Name = "lblRemain"
        Me.lblRemain.Size = New System.Drawing.Size(34, 15)
        Me.lblRemain.TabIndex = 10
        Me.lblRemain.Text = "___"
        '
        'lblSpent
        '
        Me.lblSpent.AutoSize = True
        Me.lblSpent.BackColor = System.Drawing.Color.Transparent
        Me.lblSpent.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpent.ForeColor = System.Drawing.Color.White
        Me.lblSpent.Location = New System.Drawing.Point(620, 9)
        Me.lblSpent.Name = "lblSpent"
        Me.lblSpent.Size = New System.Drawing.Size(34, 15)
        Me.lblSpent.TabIndex = 11
        Me.lblSpent.Text = "___"
        '
        'frmFallin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FALLIN_Derek_Dao.My.Resources.Resources.LwIL
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(694, 655)
        Me.Controls.Add(Me.lblSpent)
        Me.Controls.Add(Me.lblRemain)
        Me.Controls.Add(Me.lblSpentTotal)
        Me.Controls.Add(Me.lblRemaining)
        Me.Controls.Add(Me.grpTester)
        Me.Controls.Add(Me.grpCharacter)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnOracle)
        Me.Controls.Add(Me.btnQuartermaster)
        Me.Controls.Add(Me.grpSecondary)
        Me.Controls.Add(Me.grpMain)
        Me.Name = "frmFallin"
        Me.Text = "FALLIN 13"
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        Me.grpSecondary.ResumeLayout(False)
        Me.grpSecondary.PerformLayout()
        Me.grpCharacter.ResumeLayout(False)
        Me.grpCharacter.PerformLayout()
        CType(Me.picPerson, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTester.ResumeLayout(False)
        Me.grpTester.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpMain As GroupBox
    Friend WithEvents rdbLaser As RadioButton
    Friend WithEvents rdbBow As RadioButton
    Friend WithEvents rdbTwoHand As RadioButton
    Friend WithEvents rdbSword As RadioButton
    Friend WithEvents rdbClub As RadioButton
    Friend WithEvents grpSecondary As GroupBox
    Friend WithEvents chkBatteries As CheckBox
    Friend WithEvents chkLute As CheckBox
    Friend WithEvents chkPerfume As CheckBox
    Friend WithEvents chkArrows As CheckBox
    Friend WithEvents chkHeavy As CheckBox
    Friend WithEvents chkHelmet As CheckBox
    Friend WithEvents chkShield As CheckBox
    Friend WithEvents chkWater As CheckBox
    Friend WithEvents chkFood As CheckBox
    Friend WithEvents btnQuartermaster As Button
    Friend WithEvents btnOracle As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents grpCharacter As GroupBox
    Friend WithEvents picPerson As PictureBox
    Friend WithEvents grpTester As GroupBox
    Friend WithEvents lblText As Label
    Friend WithEvents lblRandom As Label
    Friend WithEvents lblRandomNumber As Label
    Friend WithEvents lblSR As Label
    Friend WithEvents lblSurvivalRating As Label
    Friend WithEvents lblLidsSpent As Label
    Friend WithEvents lblLids As Label
    Friend WithEvents lblRemaining As Label
    Friend WithEvents lblSpentTotal As Label
    Friend WithEvents lblRemain As Label
    Friend WithEvents lblSpent As Label
End Class
