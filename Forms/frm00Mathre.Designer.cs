using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Mathre
{
    [DesignerGenerated()]
    public partial class FrmMathre : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMathre));
            this.mnuBaseLayer = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSecret = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRecolor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRandomify = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelloWorld = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelloWorldLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelloWorldLanguageEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelloWorldLanguageFrench = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelloWorldLanguageGerman = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelloWorldReset = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMySchool = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMySchoolToggleMascot = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRectangle = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRectangleCalculate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFavorites = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFavoriteActor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFavoriteMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFavoriteFruit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFavoriteHobby = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFavoriteColor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTemperature = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTemperatureFahrenheit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTemperatureCelsius = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDigits = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDigitsCalculate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChange = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChangeCalculate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPizza = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPizzaDelivery = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPizzaTakeout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPizzaDollars = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPizzaPercent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGrade = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCalculateMethod1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCalculateMethod2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCalculateMethod3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCalculateMethod4 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCalculateMethod5 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCalculateRandom = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.videoGameOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPS4 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXB1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRPS = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRockPS = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRPaperS = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRPScissors = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.tabSecret = new System.Windows.Forms.TabPage();
            this.tabUnknown = new System.Windows.Forms.TabPage();
            this.tabPizza = new System.Windows.Forms.TabPage();
            this.tabChange = new System.Windows.Forms.TabPage();
            this.lblChangeMakerTitle = new System.Windows.Forms.Label();
            this.tabDigits = new System.Windows.Forms.TabPage();
            this.tabTemperature = new System.Windows.Forms.TabPage();
            this.tabMyFavorites = new System.Windows.Forms.TabPage();
            this.tabRectangle = new System.Windows.Forms.TabPage();
            this.tabMySchool = new System.Windows.Forms.TabPage();
            this.tabMathre = new System.Windows.Forms.TabControl();
            this.tabHelloWorld = new System.Windows.Forms.TabPage();
            this.tabGrade = new System.Windows.Forms.TabPage();
            this.tabVideoGames = new System.Windows.Forms.TabPage();
            this.tabRPS = new System.Windows.Forms.TabPage();
            this.imgFavoriteImages = new System.Windows.Forms.ImageList(this.components);
            this.mnuBaseLayer.SuspendLayout();
            this.tabChange.SuspendLayout();
            this.tabMathre.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuBaseLayer
            // 
            this.mnuBaseLayer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mnuBaseLayer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuView});
            this.mnuBaseLayer.Location = new System.Drawing.Point(0, 0);
            this.mnuBaseLayer.Name = "mnuBaseLayer";
            this.mnuBaseLayer.Padding = new System.Windows.Forms.Padding(0);
            this.mnuBaseLayer.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mnuBaseLayer.Size = new System.Drawing.Size(1154, 24);
            this.mnuBaseLayer.TabIndex = 0;
            this.mnuBaseLayer.Text = "Menu";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSecret,
            this.mnuHelloWorld,
            this.mnuMySchool,
            this.mnuRectangle,
            this.mnuFavorites,
            this.mnuTemperature,
            this.mnuDigits,
            this.mnuChange,
            this.mnuPizza,
            this.mnuGrade,
            this.mnuExit,
            this.videoGameOrdersToolStripMenuItem,
            this.mnuRPS});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 24);
            this.mnuFile.Text = "File";
            // 
            // mnuSecret
            // 
            this.mnuSecret.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRecolor,
            this.mnuRandomify});
            this.mnuSecret.Enabled = false;
            this.mnuSecret.Name = "mnuSecret";
            this.mnuSecret.Size = new System.Drawing.Size(195, 22);
            this.mnuSecret.Text = "Super Secret Settings";
            // 
            // mnuRecolor
            // 
            this.mnuRecolor.Enabled = false;
            this.mnuRecolor.Name = "mnuRecolor";
            this.mnuRecolor.Size = new System.Drawing.Size(132, 22);
            this.mnuRecolor.Text = "Recolor";
            // 
            // mnuRandomify
            // 
            this.mnuRandomify.Name = "mnuRandomify";
            this.mnuRandomify.Size = new System.Drawing.Size(132, 22);
            this.mnuRandomify.Text = "Randomify";
            // 
            // mnuHelloWorld
            // 
            this.mnuHelloWorld.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelloWorldLanguage,
            this.mnuHelloWorldReset});
            this.mnuHelloWorld.Name = "mnuHelloWorld";
            this.mnuHelloWorld.Size = new System.Drawing.Size(195, 22);
            this.mnuHelloWorld.Text = "Hello World";
            // 
            // mnuHelloWorldLanguage
            // 
            this.mnuHelloWorldLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelloWorldLanguageEnglish,
            this.mnuHelloWorldLanguageFrench,
            this.mnuHelloWorldLanguageGerman});
            this.mnuHelloWorldLanguage.Name = "mnuHelloWorldLanguage";
            this.mnuHelloWorldLanguage.Size = new System.Drawing.Size(126, 22);
            this.mnuHelloWorldLanguage.Text = "Language";
            // 
            // mnuHelloWorldLanguageEnglish
            // 
            this.mnuHelloWorldLanguageEnglish.Image = global::Mathre.My.Resources.Resources.EnglishAtScale;
            this.mnuHelloWorldLanguageEnglish.Name = "mnuHelloWorldLanguageEnglish";
            this.mnuHelloWorldLanguageEnglish.Size = new System.Drawing.Size(116, 22);
            this.mnuHelloWorldLanguageEnglish.Text = "English";
            // 
            // mnuHelloWorldLanguageFrench
            // 
            this.mnuHelloWorldLanguageFrench.Image = global::Mathre.My.Resources.Resources.French;
            this.mnuHelloWorldLanguageFrench.Name = "mnuHelloWorldLanguageFrench";
            this.mnuHelloWorldLanguageFrench.Size = new System.Drawing.Size(116, 22);
            this.mnuHelloWorldLanguageFrench.Text = "French";
            // 
            // mnuHelloWorldLanguageGerman
            // 
            this.mnuHelloWorldLanguageGerman.Image = global::Mathre.My.Resources.Resources.German;
            this.mnuHelloWorldLanguageGerman.Name = "mnuHelloWorldLanguageGerman";
            this.mnuHelloWorldLanguageGerman.Size = new System.Drawing.Size(116, 22);
            this.mnuHelloWorldLanguageGerman.Text = "German";
            // 
            // mnuHelloWorldReset
            // 
            this.mnuHelloWorldReset.Name = "mnuHelloWorldReset";
            this.mnuHelloWorldReset.Size = new System.Drawing.Size(126, 22);
            this.mnuHelloWorldReset.Text = "Reset";
            // 
            // mnuMySchool
            // 
            this.mnuMySchool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMySchoolToggleMascot});
            this.mnuMySchool.Name = "mnuMySchool";
            this.mnuMySchool.Size = new System.Drawing.Size(195, 22);
            this.mnuMySchool.Text = "My School";
            // 
            // mnuMySchoolToggleMascot
            // 
            this.mnuMySchoolToggleMascot.Name = "mnuMySchoolToggleMascot";
            this.mnuMySchoolToggleMascot.Size = new System.Drawing.Size(198, 22);
            this.mnuMySchoolToggleMascot.Text = "Toggle Mascot Visibility";
            // 
            // mnuRectangle
            // 
            this.mnuRectangle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRectangleCalculate});
            this.mnuRectangle.Name = "mnuRectangle";
            this.mnuRectangle.Size = new System.Drawing.Size(195, 22);
            this.mnuRectangle.Text = "Rectangle Calculator";
            // 
            // mnuRectangleCalculate
            // 
            this.mnuRectangleCalculate.Name = "mnuRectangleCalculate";
            this.mnuRectangleCalculate.Size = new System.Drawing.Size(123, 22);
            this.mnuRectangleCalculate.Text = "Calculate";
            // 
            // mnuFavorites
            // 
            this.mnuFavorites.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFavoriteActor,
            this.mnuFavoriteMovie,
            this.mnuFavoriteFruit,
            this.mnuFavoriteHobby,
            this.mnuFavoriteColor});
            this.mnuFavorites.Name = "mnuFavorites";
            this.mnuFavorites.Size = new System.Drawing.Size(195, 22);
            this.mnuFavorites.Text = "My Favorites";
            // 
            // mnuFavoriteActor
            // 
            this.mnuFavoriteActor.Name = "mnuFavoriteActor";
            this.mnuFavoriteActor.Size = new System.Drawing.Size(110, 22);
            this.mnuFavoriteActor.Text = "Actor";
            // 
            // mnuFavoriteMovie
            // 
            this.mnuFavoriteMovie.Name = "mnuFavoriteMovie";
            this.mnuFavoriteMovie.Size = new System.Drawing.Size(110, 22);
            this.mnuFavoriteMovie.Text = "Movie";
            // 
            // mnuFavoriteFruit
            // 
            this.mnuFavoriteFruit.Name = "mnuFavoriteFruit";
            this.mnuFavoriteFruit.Size = new System.Drawing.Size(110, 22);
            this.mnuFavoriteFruit.Text = "Fruit";
            // 
            // mnuFavoriteHobby
            // 
            this.mnuFavoriteHobby.Name = "mnuFavoriteHobby";
            this.mnuFavoriteHobby.Size = new System.Drawing.Size(110, 22);
            this.mnuFavoriteHobby.Text = "Hobby";
            // 
            // mnuFavoriteColor
            // 
            this.mnuFavoriteColor.Name = "mnuFavoriteColor";
            this.mnuFavoriteColor.Size = new System.Drawing.Size(110, 22);
            this.mnuFavoriteColor.Text = "Color";
            // 
            // mnuTemperature
            // 
            this.mnuTemperature.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTemperatureFahrenheit,
            this.mnuTemperatureCelsius});
            this.mnuTemperature.Name = "mnuTemperature";
            this.mnuTemperature.Size = new System.Drawing.Size(195, 22);
            this.mnuTemperature.Text = "Temperature Converter";
            // 
            // mnuTemperatureFahrenheit
            // 
            this.mnuTemperatureFahrenheit.Name = "mnuTemperatureFahrenheit";
            this.mnuTemperatureFahrenheit.Size = new System.Drawing.Size(130, 22);
            this.mnuTemperatureFahrenheit.Text = "Fahrenheit";
            // 
            // mnuTemperatureCelsius
            // 
            this.mnuTemperatureCelsius.Name = "mnuTemperatureCelsius";
            this.mnuTemperatureCelsius.Size = new System.Drawing.Size(130, 22);
            this.mnuTemperatureCelsius.Text = "Celsius";
            // 
            // mnuDigits
            // 
            this.mnuDigits.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDigitsCalculate});
            this.mnuDigits.Name = "mnuDigits";
            this.mnuDigits.Size = new System.Drawing.Size(195, 22);
            this.mnuDigits.Text = "Digit Separator";
            // 
            // mnuDigitsCalculate
            // 
            this.mnuDigitsCalculate.Name = "mnuDigitsCalculate";
            this.mnuDigitsCalculate.Size = new System.Drawing.Size(123, 22);
            this.mnuDigitsCalculate.Text = "Calculate";
            // 
            // mnuChange
            // 
            this.mnuChange.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChangeCalculate});
            this.mnuChange.Name = "mnuChange";
            this.mnuChange.Size = new System.Drawing.Size(195, 22);
            this.mnuChange.Text = "Change Maker";
            // 
            // mnuChangeCalculate
            // 
            this.mnuChangeCalculate.Name = "mnuChangeCalculate";
            this.mnuChangeCalculate.Size = new System.Drawing.Size(123, 22);
            this.mnuChangeCalculate.Text = "Calculate";
            // 
            // mnuPizza
            // 
            this.mnuPizza.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPizzaDelivery,
            this.mnuPizzaTakeout,
            this.mnuPizzaDollars,
            this.mnuPizzaPercent});
            this.mnuPizza.Name = "mnuPizza";
            this.mnuPizza.Size = new System.Drawing.Size(195, 22);
            this.mnuPizza.Text = "Pizza Delivery";
            // 
            // mnuPizzaDelivery
            // 
            this.mnuPizzaDelivery.Name = "mnuPizzaDelivery";
            this.mnuPizzaDelivery.Size = new System.Drawing.Size(116, 22);
            this.mnuPizzaDelivery.Text = "Delivery";
            // 
            // mnuPizzaTakeout
            // 
            this.mnuPizzaTakeout.Name = "mnuPizzaTakeout";
            this.mnuPizzaTakeout.Size = new System.Drawing.Size(116, 22);
            this.mnuPizzaTakeout.Text = "Takeout";
            // 
            // mnuPizzaDollars
            // 
            this.mnuPizzaDollars.Name = "mnuPizzaDollars";
            this.mnuPizzaDollars.Size = new System.Drawing.Size(116, 22);
            this.mnuPizzaDollars.Text = "Dollars";
            // 
            // mnuPizzaPercent
            // 
            this.mnuPizzaPercent.Name = "mnuPizzaPercent";
            this.mnuPizzaPercent.Size = new System.Drawing.Size(116, 22);
            this.mnuPizzaPercent.Text = "Percent";
            // 
            // mnuGrade
            // 
            this.mnuGrade.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCalculateMethod1,
            this.mnuCalculateMethod2,
            this.mnuCalculateMethod3,
            this.mnuCalculateMethod4,
            this.mnuCalculateMethod5,
            this.mnuCalculateRandom});
            this.mnuGrade.Name = "mnuGrade";
            this.mnuGrade.Size = new System.Drawing.Size(195, 22);
            this.mnuGrade.Text = "Calculate My Grade";
            // 
            // mnuCalculateMethod1
            // 
            this.mnuCalculateMethod1.Name = "mnuCalculateMethod1";
            this.mnuCalculateMethod1.Size = new System.Drawing.Size(125, 22);
            this.mnuCalculateMethod1.Text = "Method 1";
            // 
            // mnuCalculateMethod2
            // 
            this.mnuCalculateMethod2.Name = "mnuCalculateMethod2";
            this.mnuCalculateMethod2.Size = new System.Drawing.Size(125, 22);
            this.mnuCalculateMethod2.Text = "Method 2";
            // 
            // mnuCalculateMethod3
            // 
            this.mnuCalculateMethod3.Name = "mnuCalculateMethod3";
            this.mnuCalculateMethod3.Size = new System.Drawing.Size(125, 22);
            this.mnuCalculateMethod3.Text = "Method 3";
            // 
            // mnuCalculateMethod4
            // 
            this.mnuCalculateMethod4.Name = "mnuCalculateMethod4";
            this.mnuCalculateMethod4.Size = new System.Drawing.Size(125, 22);
            this.mnuCalculateMethod4.Text = "Method 4";
            // 
            // mnuCalculateMethod5
            // 
            this.mnuCalculateMethod5.Name = "mnuCalculateMethod5";
            this.mnuCalculateMethod5.Size = new System.Drawing.Size(125, 22);
            this.mnuCalculateMethod5.Text = "Method 5";
            // 
            // mnuCalculateRandom
            // 
            this.mnuCalculateRandom.Name = "mnuCalculateRandom";
            this.mnuCalculateRandom.Size = new System.Drawing.Size(125, 22);
            this.mnuCalculateRandom.Text = "Random";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(195, 22);
            this.mnuExit.Text = "Exit";
            // 
            // videoGameOrdersToolStripMenuItem
            // 
            this.videoGameOrdersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPS4,
            this.mnuXB1});
            this.videoGameOrdersToolStripMenuItem.Name = "videoGameOrdersToolStripMenuItem";
            this.videoGameOrdersToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.videoGameOrdersToolStripMenuItem.Text = "Video Game Orders";
            // 
            // mnuPS4
            // 
            this.mnuPS4.Name = "mnuPS4";
            this.mnuPS4.Size = new System.Drawing.Size(141, 22);
            this.mnuPS4.Text = "Playstation 4";
            // 
            // mnuXB1
            // 
            this.mnuXB1.Name = "mnuXB1";
            this.mnuXB1.Size = new System.Drawing.Size(141, 22);
            this.mnuXB1.Text = "Xbox One";
            // 
            // mnuRPS
            // 
            this.mnuRPS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRockPS,
            this.mnuRPaperS,
            this.mnuRPScissors});
            this.mnuRPS.Name = "mnuRPS";
            this.mnuRPS.Size = new System.Drawing.Size(195, 22);
            this.mnuRPS.Text = "Rock Paper Scissors";
            // 
            // mnuRockPS
            // 
            this.mnuRockPS.Name = "mnuRockPS";
            this.mnuRockPS.Size = new System.Drawing.Size(115, 22);
            this.mnuRockPS.Text = "Rock";
            // 
            // mnuRPaperS
            // 
            this.mnuRPaperS.Name = "mnuRPaperS";
            this.mnuRPaperS.Size = new System.Drawing.Size(115, 22);
            this.mnuRPaperS.Text = "Paper";
            // 
            // mnuRPScissors
            // 
            this.mnuRPScissors.Name = "mnuRPScissors";
            this.mnuRPScissors.Size = new System.Drawing.Size(115, 22);
            this.mnuRPScissors.Text = "Scissors";
            // 
            // mnuEdit
            // 
            this.mnuEdit.Enabled = false;
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(39, 24);
            this.mnuEdit.Text = "Edit";
            // 
            // mnuView
            // 
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(44, 24);
            this.mnuView.Text = "View";
            // 
            // tabSecret
            // 
            this.tabSecret.Location = new System.Drawing.Point(4, 22);
            this.tabSecret.Name = "tabSecret";
            this.tabSecret.Size = new System.Drawing.Size(1146, 0);
            this.tabSecret.TabIndex = 3;
            this.tabSecret.Text = "Secret Settings Page";
            this.tabSecret.UseVisualStyleBackColor = true;
            // 
            // tabUnknown
            // 
            this.tabUnknown.Location = new System.Drawing.Point(4, 22);
            this.tabUnknown.Margin = new System.Windows.Forms.Padding(0);
            this.tabUnknown.Name = "tabUnknown";
            this.tabUnknown.Size = new System.Drawing.Size(1146, 0);
            this.tabUnknown.TabIndex = 2;
            this.tabUnknown.Text = "...";
            this.tabUnknown.UseVisualStyleBackColor = true;
            // 
            // tabPizza
            // 
            this.tabPizza.Location = new System.Drawing.Point(4, 22);
            this.tabPizza.Name = "tabPizza";
            this.tabPizza.Size = new System.Drawing.Size(1146, 0);
            this.tabPizza.TabIndex = 9;
            this.tabPizza.Tag = "";
            this.tabPizza.Text = "Pizza Delivery";
            this.tabPizza.UseVisualStyleBackColor = true;
            // 
            // tabChange
            // 
            this.tabChange.Controls.Add(this.lblChangeMakerTitle);
            this.tabChange.Location = new System.Drawing.Point(4, 22);
            this.tabChange.Name = "tabChange";
            this.tabChange.Size = new System.Drawing.Size(1146, 0);
            this.tabChange.TabIndex = 8;
            this.tabChange.Text = "Change Maker";
            this.tabChange.UseVisualStyleBackColor = true;
            // 
            // lblChangeMakerTitle
            // 
            this.lblChangeMakerTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblChangeMakerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeMakerTitle.Location = new System.Drawing.Point(94, 801);
            this.lblChangeMakerTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblChangeMakerTitle.Name = "lblChangeMakerTitle";
            this.lblChangeMakerTitle.Size = new System.Drawing.Size(626, 51);
            this.lblChangeMakerTitle.TabIndex = 20;
            this.lblChangeMakerTitle.Text = "Change Maker";
            this.lblChangeMakerTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabDigits
            // 
            this.tabDigits.Location = new System.Drawing.Point(4, 22);
            this.tabDigits.Name = "tabDigits";
            this.tabDigits.Size = new System.Drawing.Size(1146, 0);
            this.tabDigits.TabIndex = 7;
            this.tabDigits.Text = "Digit Separator";
            this.tabDigits.UseVisualStyleBackColor = true;
            // 
            // tabTemperature
            // 
            this.tabTemperature.Location = new System.Drawing.Point(4, 22);
            this.tabTemperature.Name = "tabTemperature";
            this.tabTemperature.Size = new System.Drawing.Size(1146, 0);
            this.tabTemperature.TabIndex = 6;
            this.tabTemperature.Text = "Temperature Converter";
            this.tabTemperature.UseVisualStyleBackColor = true;
            // 
            // tabMyFavorites
            // 
            this.tabMyFavorites.Location = new System.Drawing.Point(4, 22);
            this.tabMyFavorites.Name = "tabMyFavorites";
            this.tabMyFavorites.Size = new System.Drawing.Size(1146, 0);
            this.tabMyFavorites.TabIndex = 5;
            this.tabMyFavorites.Text = "My Favorites";
            this.tabMyFavorites.UseVisualStyleBackColor = true;
            // 
            // tabRectangle
            // 
            this.tabRectangle.Location = new System.Drawing.Point(4, 22);
            this.tabRectangle.Name = "tabRectangle";
            this.tabRectangle.Size = new System.Drawing.Size(1146, 0);
            this.tabRectangle.TabIndex = 4;
            this.tabRectangle.Text = "Rectangle Calculator";
            this.tabRectangle.UseVisualStyleBackColor = true;
            // 
            // tabMySchool
            // 
            this.tabMySchool.Location = new System.Drawing.Point(4, 22);
            this.tabMySchool.Name = "tabMySchool";
            this.tabMySchool.Size = new System.Drawing.Size(1146, 0);
            this.tabMySchool.TabIndex = 1;
            this.tabMySchool.Text = "My School";
            this.tabMySchool.UseVisualStyleBackColor = true;
            // 
            // tabMathre
            // 
            this.tabMathre.Controls.Add(this.tabHelloWorld);
            this.tabMathre.Controls.Add(this.tabMySchool);
            this.tabMathre.Controls.Add(this.tabRectangle);
            this.tabMathre.Controls.Add(this.tabMyFavorites);
            this.tabMathre.Controls.Add(this.tabTemperature);
            this.tabMathre.Controls.Add(this.tabDigits);
            this.tabMathre.Controls.Add(this.tabChange);
            this.tabMathre.Controls.Add(this.tabPizza);
            this.tabMathre.Controls.Add(this.tabGrade);
            this.tabMathre.Controls.Add(this.tabVideoGames);
            this.tabMathre.Controls.Add(this.tabRPS);
            this.tabMathre.Controls.Add(this.tabUnknown);
            this.tabMathre.Controls.Add(this.tabSecret);
            this.tabMathre.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabMathre.Location = new System.Drawing.Point(0, 24);
            this.tabMathre.Margin = new System.Windows.Forms.Padding(0);
            this.tabMathre.Name = "tabMathre";
            this.tabMathre.SelectedIndex = 0;
            this.tabMathre.Size = new System.Drawing.Size(1154, 21);
            this.tabMathre.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabMathre.TabIndex = 4;
            this.tabMathre.Tag = "";
            // 
            // tabHelloWorld
            // 
            this.tabHelloWorld.BackColor = System.Drawing.Color.Transparent;
            this.tabHelloWorld.Location = new System.Drawing.Point(4, 22);
            this.tabHelloWorld.Name = "tabHelloWorld";
            this.tabHelloWorld.Size = new System.Drawing.Size(1146, 0);
            this.tabHelloWorld.TabIndex = 0;
            this.tabHelloWorld.Text = "Hello World";
            // 
            // tabGrade
            // 
            this.tabGrade.Location = new System.Drawing.Point(4, 22);
            this.tabGrade.Name = "tabGrade";
            this.tabGrade.Size = new System.Drawing.Size(1146, 0);
            this.tabGrade.TabIndex = 10;
            this.tabGrade.Text = "Calculate My Grade";
            this.tabGrade.UseVisualStyleBackColor = true;
            // 
            // tabVideoGames
            // 
            this.tabVideoGames.Location = new System.Drawing.Point(4, 22);
            this.tabVideoGames.Name = "tabVideoGames";
            this.tabVideoGames.Size = new System.Drawing.Size(1146, 0);
            this.tabVideoGames.TabIndex = 11;
            this.tabVideoGames.Text = "Video Game Orders";
            this.tabVideoGames.UseVisualStyleBackColor = true;
            // 
            // tabRPS
            // 
            this.tabRPS.Location = new System.Drawing.Point(4, 22);
            this.tabRPS.Name = "tabRPS";
            this.tabRPS.Size = new System.Drawing.Size(1146, 0);
            this.tabRPS.TabIndex = 12;
            this.tabRPS.Text = "Rock Paper Scissors";
            this.tabRPS.UseVisualStyleBackColor = true;
            // 
            // imgFavoriteImages
            // 
            this.imgFavoriteImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgFavoriteImages.ImageStream")));
            this.imgFavoriteImages.TransparentColor = System.Drawing.Color.Transparent;
            this.imgFavoriteImages.Images.SetKeyName(0, "Actor.jpg");
            this.imgFavoriteImages.Images.SetKeyName(1, "Fruit.jpg");
            this.imgFavoriteImages.Images.SetKeyName(2, "Hobby.jpg");
            this.imgFavoriteImages.Images.SetKeyName(3, "Movie.jpg");
            this.imgFavoriteImages.Images.SetKeyName(4, "LargePizza.png");
            this.imgFavoriteImages.Images.SetKeyName(5, "MediumPizza.png");
            this.imgFavoriteImages.Images.SetKeyName(6, "SmallPizza.png");
            // 
            // FrmMathre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1154, 461);
            this.Controls.Add(this.tabMathre);
            this.Controls.Add(this.mnuBaseLayer);
            this.KeyPreview = true;
            this.MainMenuStrip = this.mnuBaseLayer;
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "FrmMathre";
            this.Text = "Mathre";
            this.Load += new System.EventHandler(this.FormLoad);
            this.mnuBaseLayer.ResumeLayout(false);
            this.mnuBaseLayer.PerformLayout();
            this.tabChange.ResumeLayout(false);
            this.tabMathre.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal ToolStripMenuItem mnuEdit;
        internal ToolStripMenuItem mnuView;
		internal TabPage tabSecret;
		internal TabPage tabUnknown;
		private TabPage tabPizza;
		private TabPage tabChange;
		internal Label lblChangeMakerTitle;
		private TabPage tabDigits;
		private TabPage tabTemperature;
		internal TabControl tabMathre;
		public ToolStripMenuItem mnuFile;
		public ToolStripMenuItem mnuHelloWorld;
		public ToolStripMenuItem mnuHelloWorldLanguage;
		public ToolStripMenuItem mnuHelloWorldLanguageEnglish;
		public ToolStripMenuItem mnuHelloWorldLanguageFrench;
		public ToolStripMenuItem mnuHelloWorldLanguageGerman;
		public ToolStripMenuItem mnuHelloWorldReset;
		public ToolStripMenuItem mnuMySchool;
		public ToolStripMenuItem mnuMySchoolToggleMascot;
		public ToolStripMenuItem mnuExit;
		public ToolStripMenuItem mnuRectangle;
		public ToolStripMenuItem mnuRectangleCalculate;
		public ToolStripMenuItem mnuFavorites;
		public ToolStripMenuItem mnuFavoriteActor;
		public ToolStripMenuItem mnuFavoriteMovie;
		public ToolStripMenuItem mnuFavoriteFruit;
		public ToolStripMenuItem mnuFavoriteColor;
		public ToolStripMenuItem mnuFavoriteHobby;
		public ToolStripMenuItem mnuTemperature;
		public ToolStripMenuItem mnuTemperatureFahrenheit;
		public ToolStripMenuItem mnuTemperatureCelsius;
		public ToolStripMenuItem mnuDigits;
		public ToolStripMenuItem mnuDigitsCalculate;
		public ToolStripMenuItem mnuChange;
		public ToolStripMenuItem mnuChangeCalculate;
		public ToolStripMenuItem mnuPizza;
		public ToolStripMenuItem mnuPizzaTakeout;
		public ToolStripMenuItem mnuPizzaDelivery;
		public ToolStripMenuItem mnuPizzaDollars;
		public ToolStripMenuItem mnuPizzaPercent;
		public MenuStrip mnuBaseLayer;
		private TabPage tabGrade;
		internal ToolStripMenuItem mnuSecret;
		internal ToolStripMenuItem mnuRecolor;
		internal ToolStripMenuItem mnuRandomify;
		public ToolStripMenuItem mnuGrade;
		public ToolStripMenuItem mnuCalculateMethod1;
		public ToolStripMenuItem mnuCalculateMethod2;
		public ToolStripMenuItem mnuCalculateMethod3;
		public ToolStripMenuItem mnuCalculateMethod4;
		public ToolStripMenuItem mnuCalculateMethod5;
		public ToolStripMenuItem mnuCalculateRandom;
		private TabPage tabVideoGames;
		public ImageList imgFavoriteImages;
		public ToolStripMenuItem videoGameOrdersToolStripMenuItem;
		public ToolStripMenuItem mnuPS4;
		public ToolStripMenuItem mnuXB1;
		internal TabPage tabRPS;
		private TabPage tabMyFavorites;
		private TabPage tabRectangle;
		private TabPage tabMySchool;
		private TabPage tabHelloWorld;
		private ToolStripMenuItem mnuRPS;
		private ToolStripMenuItem mnuRockPS;
		private ToolStripMenuItem mnuRPaperS;
		private ToolStripMenuItem mnuRPScissors;
	}
}
