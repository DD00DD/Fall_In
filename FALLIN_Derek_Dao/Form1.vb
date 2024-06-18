Public Class frmFallin
    ' Name: FALLIN 13
    ' Programmer: Derek Dao
    ' Date Written: November 22, 2018
    ' Description: A program that helps players of FALLIN decide
    '              what equipment to take to survive their adventure.   
    ' History: November 22,2018   Created
    '          November 23, 2018  Finished quartermaster button, Oracle
    '                             button and the first two extended
    '          November 26,2018 Added Comments and the final two extended
    '          November 27,2018 Added test cases

    ' Test Case 1: Player survives
    ' Buttons to check: Bow, Arrows, Shield and Helmet
    ' Top right cornor Lids Spent: 130
    ' Top right cornor Lids Remain: 70
    ' Lids spent (tester case) : 130
    ' Survival Rate: 15
    ' Random number: Any from 0 to 13
    ' Quartermaster: Approved
    ' Oracle: The player survives.

    ' Test Case 2: Player didn't survive
    ' Buttons to check: Bow, Perfume, and Lute
    ' Top right cornor Lids Spent: 90
    ' Top right cornor Lids Remain: 110
    ' Lids spent (tester case) : 90
    ' Survival Rate: -20
    ' Random number: Any from 0 to 13
    ' Quartermaster: Approved
    ' Oracle: Player did not survive.

    'The starting value of the lids and survival rate.
    Const lidsLimit As Integer = 0
    Const survivalRate As Integer = 0

    Private Sub btnQuartermaster_Click(sender As Object, e As EventArgs) Handles btnQuartermaster.Click
        ' This is the Quartermaster's button
        ' Primary/Main group input.
        Dim club As Boolean = False
        Dim sword As Boolean = False
        Dim twoHand As Boolean = False
        Dim bow As Boolean = False
        Dim laser As Boolean = False

        ' Secondary items input.
        Dim food As Boolean = False
        Dim water As Boolean = False
        Dim shield As Boolean = False
        Dim helmet As Boolean = False
        Dim heavyGloves As Boolean = False
        Dim arrows As Boolean = False
        Dim perfume As Boolean = False
        Dim lute As Boolean = False
        Dim batteries As Boolean = False

        ' Input for lids.
        Dim lids As Integer

        ' Assigning each variable a specific button.
        club = Me.rdbClub.Checked
        sword = Me.rdbSword.Checked
        twoHand = Me.rdbTwoHand.Checked
        bow = Me.rdbBow.Checked
        laser = Me.rdbLaser.Checked

        food = Me.chkFood.Checked
        water = Me.chkWater.Checked
        shield = Me.chkShield.Checked
        helmet = Me.chkHelmet.Checked
        heavyGloves = Me.chkHeavy.Checked
        arrows = Me.chkArrows.Checked
        perfume = Me.chkPerfume.Checked
        lute = Me.chkLute.Checked
        batteries = Me.chkBatteries.Checked

        ' Primary/Main weapon radiobutton choices that
        ' calculates the amount of lids.
        If club Then
            lids = lidsLimit + 0

        ElseIf sword Then
            lids = lidsLimit + 50

        ElseIf twoHand Then
            lids = lidsLimit + 40

        ElseIf bow Then
            lids = lids + 40

        ElseIf laser Then   ' The extended laser option.
            lids = lidsLimit + 100
        End If

        'Secondary items choice that adds on to total amount of lids.
        If food Then
            lids = lids + 50
        End If

        If water Then
            lids = lids + 60
        End If

        If shield Then
            lids = lids + 40
        End If

        If helmet Then
            lids = lids + 30
        End If

        If heavyGloves Then ' Extended heavy gloves option.
            lids = lids + 20
        End If

        If arrows Then
            lids = lids + 20
        End If

        If perfume Then
            lids = lids + 10
        End If

        If lute Then
            lids = lids + 40
        End If

        If batteries Then   ' Extended batteries option for laser
            lids = lids + 10
        End If

        ' Dialogue and validation for spending over 200 lids.
        If lids > 200 Then
            Me.lblText.Text = "You've overspent on lids, Private!"
            MessageBox.Show("You've overspent your 200 of your lids, Please Re-Select items or Start Over to gain approval from the quartermaster.")
            Me.btnOracle.Enabled = False

            ' Dialogue and validation for selecting restriction
            ' in 200 lids or less and also for completing the 
            ' selection properly.
        ElseIf lids <= 200 Then
            If twoHand And shield Then      ' Validation for two hand sword and shield combo.
                Me.lblText.Text = "You've Selected the two" & Environment.NewLine &
                                  "hand sword and shield" & Environment.NewLine &
                                  "combination, maggot!" & Environment.NewLine &
                                  "Head straight to the" & Environment.NewLine &
                                  "options And Re-Select Or" & Environment.NewLine &
                                  "Start over, That's an order!"
                MessageBox.Show("Cannnot use the Shield and Two hand sword combination, Please Re-Select items or Start Over.")
                Me.btnOracle.Enabled = False

            ElseIf Not laser And batteries Then ' Validation for not selecting laser with batteries.
                Me.lblText.Text = "MAGGOT! YOU CAN" & Environment.NewLine &
                                  "ONLY SELECT BATTERIES" & Environment.NewLine &
                                  "WITH A LASER"
                MessageBox.Show("Can only select batteries with laser.")
                Me.btnOracle.Enabled = False

            ElseIf heavyGloves And bow Then     ' Validation for selecting the heavy gloves and bow combo.
                Me.lblText.Text = "YOU CANNOT USE THE" & Environment.NewLine &
                                  "HEAVY GLOVES WITH THE" & Environment.NewLine &
                                  "BOW! MAGGOT!!!"
                MessageBox.Show("Cannot combine heavy gloves with bow.")
                Me.btnOracle.Enabled = False

            Else
                Me.lblText.Text = "It's been an honor maggot..." & Environment.NewLine &
                                  "You've gained my approval" & Environment.NewLine &
                                  "Now, Check up with Oracle" & Environment.NewLine &
                                  "Good luck, Soldier!"
                Me.btnOracle.Enabled = True
            End If
        End If

        ' Output of the total lids spent in the tester's display
        Me.lblLids.Text = lids

        ' A picture box that is used for the quartermaster gif
        Me.picPerson.Image = My.Resources.ezgif_4_cfe39930c716
    End Sub

    Private Sub btnOracle_Click(sender As Object, e As EventArgs) Handles btnOracle.Click
        ' This is the Oracle button.
        ' Primary/Main group input.
        Dim club As Boolean = False
        Dim sword As Boolean = False
        Dim twoHand As Boolean = False
        Dim bow As Boolean = False
        Dim laser As Boolean = False

        ' Secondary items input.
        Dim food As Boolean = False
        Dim water As Boolean = False
        Dim shield As Boolean = False
        Dim helmet As Boolean = False
        Dim heavyGloves As Boolean = False
        Dim arrows As Boolean = False
        Dim perfume As Boolean = False
        Dim lute As Boolean = False
        Dim batteries As Boolean = False

        ' Survival rate and total lids input.
        Dim survival As Integer
        Dim lids As Integer

        ' Randomize number input.
        Dim highNum As Integer = 13
        Dim lowNum As Integer = 0
        Dim randomNum As Integer

        ' Assigning each variable a specific button.
        club = Me.rdbClub.Checked
        sword = Me.rdbSword.Checked
        twoHand = Me.rdbTwoHand.Checked
        bow = Me.rdbBow.Checked
        laser = Me.rdbLaser.Checked

        food = Me.chkFood.Checked
        water = Me.chkWater.Checked
        shield = Me.chkShield.Checked
        helmet = Me.chkHelmet.Checked
        heavyGloves = Me.chkHeavy.Checked
        arrows = Me.chkArrows.Checked
        perfume = Me.chkPerfume.Checked
        lute = Me.chkLute.Checked
        batteries = Me.chkBatteries.Checked

        ' The random number equation.
        randomNum = Int((highNum - lowNum + 1) * Rnd() + lowNum)

        ' Primary/Main weapons that determines the survival rate
        ' and if the player got approval from the Quartermaster.
        If club Then
            survival = survivalRate + 1
            lids = lidsLimit + 0

        ElseIf sword Then
            survival = survivalRate + 5
            lids = lidsLimit + 50

        ElseIf twoHand Then
            survival = survivalRate + 3
            lids = lidsLimit + 40

        ElseIf bow Then
            If bow And arrows Then      ' When arrow and bow is chosen (+8)
                survival = survival + 8
                lids = lids + 60
            Else
                survival = survivalRate + (-5)
                lids = lids + 40
            End If

        ElseIf laser Then
            survival = survivalRate + 3 'Extended laser option
            lids = lidsLimit + 100
        End If

        ' Secondary items check buttons that determines the survival
        ' rate and if the player got approval from the Quartermaster.
        If food Then
            survival = survival + 1
            lids = lids + 50
        End If

        If water Then
            survival = survival + 1
            lids = lids + 60
        End If

        If shield And (Not twoHand) Then
            survival = survival + 4
            lids = lids + 40
        End If

        If helmet Then
            survival = survival + 3
            lids = lids + 30
        End If

        If heavyGloves And (Not bow) Then   ' Extended heavy gloves option.
            survival = survival + 1
            lids = lids + 20
        End If

        If arrows And (Not bow) Then
            survival = survival + 2
            lids = lids + 20
        End If

        If perfume Then
            survival = survival + (-10)
            lids = lids + 10
        End If

        If lute Then
            survival = survival + (-5)
            lids = lids + 40
        End If

        If batteries Then                   ' Extended batteries option.
            survival = survival + 5
            lids = lids + 10
        End If

        ' Dialogue and Validation for if the player uses more than 200 lids.
        If lids > 200 Then
            Me.lblText.Text = "The Quartermaster did" & Environment.NewLine &
                              "not approve of this." & Environment.NewLine &
                              "Come back to me when you" & Environment.NewLine &
                              "have the Quartermaster's" & Environment.NewLine &
                              "approval."
            MessageBox.Show("Please Change your equipment, you've overspent.")
            Me.btnOracle.Enabled = False
        End If

        ' Dialogue and Validation for spending 200 or less lids, and also
        ' selecting the restriction that the Quartermaster did not approve.
        If lids <= 200 Then
            If twoHand And shield Then
                Me.lblText.Text = "Please choose something" & Environment.NewLine &
                                  "else. The Quartermaster did" & Environment.NewLine &
                                  "not give approval for this"
                MessageBox.Show("Looks like you've chosen the two hand sword and shield combination. Please Re-select your equipment or Start Over.")
                Me.btnOracle.Enabled = False

            ElseIf Not laser And batteries Then
                Me.lblText.Text = "The Quartermaster has not given" & Environment.NewLine &
                                  "you approval for your equipment."
                MessageBox.Show("Can only select batteries with laser.")
                Me.btnOracle.Enabled = False

            ElseIf heavyGloves And bow Then
                Me.lblText.Text = "The Quartermaster did not give" & Environment.NewLine &
                                  "approval for this."
                MessageBox.Show("Cannot combine heavy gloves and bow.")
                Me.btnOracle.Enabled = False

                ' Determining if the player survived their adventure
                ' with the randomize extended part.
            Else
                If survival > randomNum Then
                    Me.lblText.Text = "Looks like you've gotten" & Environment.NewLine &
                                      "the Quartermaster's approval." & Environment.NewLine &
                                      "Oh my will you look at that, my" & Environment.NewLine &
                                      "prediction says that you will" & Environment.NewLine &
                                      "survive your upcoming adventure."

                ElseIf survival <= randomNum Then
                    Me.lblText.Text = "Looks like you've gotten the" & Environment.NewLine &
                                      "Quartermaster's approval. The" & Environment.NewLine &
                                      "bad news is well..." & Environment.NewLine &
                                      "Uhh... this might be an" & Environment.NewLine &
                                      "error in my prediction, but" & Environment.NewLine &
                                      "it looks like you will not" & Environment.NewLine &
                                      "survive your upcoming adventure."
                End If
            End If
        End If

        'Output for survival rate and the random number in tester's display.
        Me.lblSR.Text = survival
        Me.lblRandom.Text = randomNum

        ' The picturebox that makes the Oracle gif appear 
        Me.picPerson.Image = My.Resources.ezgif_com_crop
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Reset button that resets everything to their default stage.
        Me.rdbClub.Checked = True
        Me.rdbSword.Checked = False
        Me.rdbTwoHand.Checked = False
        Me.rdbBow.Checked = False
        Me.rdbLaser.Checked = False

        Me.chkFood.Checked = False
        Me.chkWater.Checked = False
        Me.chkShield.Checked = False
        Me.chkHelmet.Checked = False
        Me.chkHeavy.Checked = False
        Me.chkArrows.Checked = False
        Me.chkPerfume.Checked = False
        Me.chkLute.Checked = False
        Me.chkBatteries.Checked = False

        Me.lblLids.Text = ""
        Me.lblSR.Text = ""
        Me.lblRandom.Text = ""
        Me.lblText.Text = "Contacting...."
        Me.lblRemain.Text = 200
        Me.lblSpent.Text = 0

        Me.btnOracle.Enabled = True

        Me.picPerson.Image = My.Resources._200w
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Exit or end button
        Application.Exit()
    End Sub

    Private Sub frmFallin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' The things that are loaded once the program has started
        Randomize()
        Me.lblText.Text = "Contacting...."
        Me.lblLids.Text = ""
        Me.lblSR.Text = ""
        Me.lblRandom.Text = ""
        Me.lblRemain.Text = 200
        Me.lblSpent.Text = 0
        Me.picPerson.Image = My.Resources._200w
    End Sub

    ' From here to the bottom, it is calculating the running
    ' total of lids that was spent and the lids that are 
    ' remaining in the top right cornor.
    Private Sub rdbClub_CheckedChanged(sender As Object, e As EventArgs) Handles rdbClub.CheckedChanged
        Dim club As Boolean
        Dim remain As Integer
        Dim spent As Integer

        club = Me.rdbClub.Checked
        remain = Val(Me.lblRemain.Text)
        spent = Val(Me.lblSpent.Text)

        If club = True Then
            remain = remain - 0
            spent = spent + 0

            Me.lblRemain.Text = remain
            Me.lblSpent.Text = spent

        ElseIf club = False Then
            remain = remain + 0
            spent = spent - 0

            Me.lblRemain.Text = remain
            Me.lblSpent.Text = spent
        End If
    End Sub

    Private Sub rdbSword_CheckedChanged(sender As Object, e As EventArgs) Handles rdbSword.CheckedChanged
        Dim sword As Boolean
        Dim remain As Integer
        Dim spent As Integer

        sword = Me.rdbSword.Checked
        remain = Val(Me.lblRemain.Text)
        spent = Val(Me.lblSpent.Text)

        If sword = True Then
            remain = remain - 50
            spent = spent + 50

            Me.lblRemain.Text = remain
            Me.lblSpent.Text = spent

        ElseIf sword = False Then
            remain = remain + 50
            spent = spent - 50

            Me.lblRemain.Text = remain
            Me.lblSpent.Text = spent
        End If
    End Sub

    Private Sub rdbTwoHand_CheckedChanged(sender As Object, e As EventArgs) Handles rdbTwoHand.CheckedChanged
        Dim twohand As Boolean
        Dim remain As Integer
        Dim spent As Integer

        twohand = Me.rdbTwoHand.Checked
        remain = Val(Me.lblRemain.Text)
        spent = Val(Me.lblSpent.Text)

        If twohand = True Then
            remain = remain - 40
            spent = spent + 40

            Me.lblRemain.Text = remain
            Me.lblSpent.Text = spent

        ElseIf twohand = False Then
            remain = remain + 40
            spent = spent - 40

            Me.lblRemain.Text = remain
            Me.lblSpent.Text = spent
        End If
    End Sub

    Private Sub rdbBow_CheckedChanged(sender As Object, e As EventArgs) Handles rdbBow.CheckedChanged
        Dim bow As Boolean
        Dim remain As Integer
        Dim spent As Integer

        bow = Me.rdbBow.Checked
        remain = Val(Me.lblRemain.Text)
        spent = Val(Me.lblSpent.Text)

        If bow = True Then
            remain = remain - 40
            spent = spent + 40

            Me.lblRemain.Text = remain
            Me.lblSpent.Text = spent

        ElseIf bow = False Then
            remain = remain + 40
            spent = spent - 40

            Me.lblRemain.Text = remain
            Me.lblSpent.Text = spent
        End If
    End Sub

    Private Sub rdbLaser_CheckedChanged(sender As Object, e As EventArgs) Handles rdbLaser.CheckedChanged
        Dim laser As Boolean
        Dim remain As Integer
        Dim spent As Integer

        laser = Me.rdbLaser.Checked
        remain = Val(Me.lblRemain.Text)
        spent = Val(Me.lblSpent.Text)

        If laser = True Then
            remain = remain - 100
            spent = spent + 100

            Me.lblRemain.Text = remain
            Me.lblSpent.Text = spent

        ElseIf laser = False Then
            remain = remain + 100
            spent = spent - 100

            Me.lblRemain.Text = remain
            Me.lblSpent.Text = spent
        End If
    End Sub

    Private Sub chkFood_CheckedChanged(sender As Object, e As EventArgs) Handles chkFood.CheckedChanged
        Dim food As Boolean
        Dim remain As Integer
        Dim spent As Integer

        food = Me.chkFood.Checked
        remain = Val(Me.lblRemain.Text)
        spent = Val(Me.lblSpent.Text)

        If food = True Then
            remain = remain - 50
            spent = spent + 50

            Me.lblRemain.Text = remain
            Me.lblSpent.Text = spent

        ElseIf food = False Then
            remain = remain + 50
            spent = spent - 50

            Me.lblRemain.Text = remain
            Me.lblSpent.Text = spent
        End If
    End Sub

    Private Sub chkWater_CheckedChanged(sender As Object, e As EventArgs) Handles chkWater.CheckedChanged
        Dim water As Boolean
        Dim remain As Integer
        Dim spent As Integer

        water = Me.chkWater.Checked
        remain = Val(Me.lblRemain.Text)
        spent = Val(Me.lblSpent.Text)

        If water = True Then
            remain = remain - 60
            spent = spent + 60

            Me.lblRemain.Text = remain
            Me.lblSpent.Text = spent

        ElseIf water = False Then
            remain = remain + 60
            spent = spent - 60

            Me.lblRemain.Text = remain
            Me.lblSpent.Text = spent
        End If
    End Sub

    Private Sub chkShield_CheckedChanged(sender As Object, e As EventArgs) Handles chkShield.CheckedChanged
        Dim shield As Boolean
        Dim remain As Integer
        Dim spent As Integer

        shield = Me.chkShield.Checked
        remain = Val(Me.lblRemain.Text)
        spent = Val(Me.lblSpent.Text)

        If shield = True Then
            remain = remain - 40
            spent = spent + 40

            Me.lblRemain.Text = remain
            Me.lblSpent.Text = spent

        ElseIf shield = False Then
            remain = remain + 40
            spent = spent - 40

            Me.lblRemain.Text = remain
            Me.lblSpent.Text = spent
        End If
    End Sub

    Private Sub chkHelmet_CheckedChanged(sender As Object, e As EventArgs) Handles chkHelmet.CheckedChanged
        Dim helmet As Boolean
        Dim remain As Integer
        Dim spent As Integer

        helmet = Me.chkHelmet.Checked
        remain = Val(Me.lblRemain.Text)
        spent = Val(Me.lblSpent.Text)

        If helmet = True Then
            remain = remain - 30
            spent = spent + 30

            Me.lblRemain.Text = remain
            Me.lblSpent.Text = spent

        ElseIf helmet = False Then
            remain = remain + 30
            spent = spent - 30

            Me.lblRemain.Text = remain
            Me.lblSpent.Text = spent
        End If
    End Sub

    Private Sub chkHeavy_CheckedChanged(sender As Object, e As EventArgs) Handles chkHeavy.CheckedChanged
        Dim heavyGloves As Boolean
        Dim remain As Integer
        Dim spent As Integer

        heavyGloves = Me.chkHeavy.Checked
        remain = Val(Me.lblRemain.Text)
        spent = Val(Me.lblSpent.Text)

        If heavyGloves = True Then
            remain = remain - 20
            spent = spent + 20

            Me.lblRemain.Text = remain
            Me.lblSpent.Text = spent

        ElseIf heavyGloves = False Then
            remain = remain + 20
            spent = spent - 20

            Me.lblRemain.Text = remain
            Me.lblSpent.Text = spent
        End If
    End Sub

    Private Sub chkArrows_CheckedChanged(sender As Object, e As EventArgs) Handles chkArrows.CheckedChanged
        Dim arrows As Boolean
        Dim remain As Integer
        Dim spent As Integer

        arrows = Me.chkArrows.Checked
        remain = Val(Me.lblRemain.Text)
        spent = Val(Me.lblSpent.Text)

        If arrows = True Then
            remain = remain - 20
            spent = spent + 20

            Me.lblRemain.Text = remain
            Me.lblSpent.Text = spent

        ElseIf arrows = False Then
            remain = remain + 20
            spent = spent - 20

            Me.lblRemain.Text = remain
            Me.lblSpent.Text = spent
        End If
    End Sub

    Private Sub chkPerfume_CheckedChanged(sender As Object, e As EventArgs) Handles chkPerfume.CheckedChanged
        Dim perfume As Boolean
        Dim remain As Integer
        Dim spent As Integer

        perfume = Me.chkPerfume.Checked
        remain = Val(Me.lblRemain.Text)
        spent = Val(Me.lblSpent.Text)

        If perfume = True Then
            remain = remain - 10
            spent = spent + 10

            Me.lblRemain.Text = remain
            Me.lblSpent.Text = spent

        ElseIf perfume = False Then
            remain = remain + 10
            spent = spent - 10

            Me.lblRemain.Text = remain
            Me.lblSpent.Text = spent
        End If
    End Sub

    Private Sub chkLute_CheckedChanged(sender As Object, e As EventArgs) Handles chkLute.CheckedChanged
        Dim lute As Boolean
        Dim remain As Integer
        Dim spent As Integer

        lute = Me.chkLute.Checked
        remain = Val(Me.lblRemain.Text)
        spent = Val(Me.lblSpent.Text)

        If lute = True Then
            remain = remain - 40
            spent = spent + 40

            Me.lblRemain.Text = remain
            Me.lblSpent.Text = spent

        ElseIf lute = False Then
            remain = remain + 40
            spent = spent - 40

            Me.lblRemain.Text = remain
            Me.lblSpent.Text = spent
        End If
    End Sub

    Private Sub chkBatteries_CheckedChanged(sender As Object, e As EventArgs) Handles chkBatteries.CheckedChanged
        Dim batteries As Boolean
        Dim remain As Integer
        Dim spent As Integer

        batteries = Me.chkBatteries.Checked
        remain = Val(Me.lblRemain.Text)
        spent = Val(Me.lblSpent.Text)

        If batteries = True Then
            remain = remain - 10
            spent = spent + 10

            Me.lblRemain.Text = remain
            Me.lblSpent.Text = spent

        ElseIf batteries = False Then
            remain = remain + 10
            spent = spent - 10

            Me.lblRemain.Text = remain
            Me.lblSpent.Text = spent
        End If
    End Sub
End Class

