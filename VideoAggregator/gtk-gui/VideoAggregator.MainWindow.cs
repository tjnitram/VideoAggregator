
// This file has been generated by the GUI designer. Do not modify.
namespace VideoAggregator
{
	public partial class MainWindow
	{
		private global::Gtk.UIManager UIManager;
		
		private global::Gtk.Action OptionsAction;
		
		private global::Gtk.Action BrowserSetUpAction;
		
		private global::Gtk.Action HelpAction;
		
		private global::Gtk.Action AboutAction;
		
		private global::Gtk.VBox container;
		
		private global::Gtk.MenuBar menubar;
		
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.Button backButton;
		
		private global::Gtk.HBox hbox3;
		
		private global::Gtk.ComboBox sourceComboBox;
		
		private global::Gtk.VBox vbox2;
		
		private global::Gtk.RadioButton showRadioButton;
		
		private global::Gtk.RadioButton movieRadioButton;
		
		private global::Gtk.Button popularButton;
		
		private global::Gtk.HBox hbox4;
		
		private global::Gtk.Entry searchEntry;
		
		private global::Gtk.Button searchButton;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget VideoAggregator.MainWindow
			this.UIManager = new global::Gtk.UIManager ();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
			this.OptionsAction = new global::Gtk.Action ("OptionsAction", global::Mono.Unix.Catalog.GetString ("Options"), null, null);
			this.OptionsAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Options");
			w1.Add (this.OptionsAction, null);
			this.BrowserSetUpAction = new global::Gtk.Action ("BrowserSetUpAction", global::Mono.Unix.Catalog.GetString ("Browser Set Up"), null, null);
			this.BrowserSetUpAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Browser Set Up");
			w1.Add (this.BrowserSetUpAction, null);
			this.HelpAction = new global::Gtk.Action ("HelpAction", global::Mono.Unix.Catalog.GetString ("Help"), null, null);
			this.HelpAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Help");
			w1.Add (this.HelpAction, null);
			this.AboutAction = new global::Gtk.Action ("AboutAction", global::Mono.Unix.Catalog.GetString ("About"), null, null);
			this.AboutAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("About");
			w1.Add (this.AboutAction, null);
			this.UIManager.InsertActionGroup (w1, 0);
			this.AddAccelGroup (this.UIManager.AccelGroup);
			this.Name = "VideoAggregator.MainWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("Raspberry Video Aggregator");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child VideoAggregator.MainWindow.Gtk.Container+ContainerChild
			this.container = new global::Gtk.VBox ();
			this.container.Name = "container";
			this.container.Spacing = 6;
			// Container child container.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString (@"<ui><menubar name='menubar'><menu name='OptionsAction' action='OptionsAction'><menuitem name='BrowserSetUpAction' action='BrowserSetUpAction'/></menu><menu name='HelpAction' action='HelpAction'><menuitem name='AboutAction' action='AboutAction'/></menu></menubar></ui>");
			this.menubar = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar")));
			this.menubar.Name = "menubar";
			this.container.Add (this.menubar);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.container [this.menubar]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child container.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.backButton = new global::Gtk.Button ();
			this.backButton.WidthRequest = 60;
			this.backButton.CanFocus = true;
			this.backButton.Name = "backButton";
			this.backButton.UseUnderline = true;
			this.backButton.Label = global::Mono.Unix.Catalog.GetString ("Back");
			this.hbox1.Add (this.backButton);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.backButton]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.sourceComboBox = global::Gtk.ComboBox.NewText ();
			this.sourceComboBox.AppendText (global::Mono.Unix.Catalog.GetString ("All"));
			this.sourceComboBox.AppendText (global::Mono.Unix.Catalog.GetString ("Hulu"));
			this.sourceComboBox.AppendText (global::Mono.Unix.Catalog.GetString ("Amazon"));
			this.sourceComboBox.AppendText (global::Mono.Unix.Catalog.GetString ("YouTube"));
			global::Gtk.Tooltips w4 = new Gtk.Tooltips ();
			w4.SetTip (this.sourceComboBox, "Sources", "Sources");
			this.sourceComboBox.WidthRequest = 200;
			this.sourceComboBox.Name = "sourceComboBox";
			this.sourceComboBox.Active = 0;
			this.hbox3.Add (this.sourceComboBox);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.sourceComboBox]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 1;
			// Container child vbox2.Gtk.Box+BoxChild
			this.showRadioButton = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Show"));
			this.showRadioButton.CanFocus = true;
			this.showRadioButton.Name = "showRadioButton";
			this.showRadioButton.DrawIndicator = true;
			this.showRadioButton.UseUnderline = true;
			this.showRadioButton.Group = new global::GLib.SList (global::System.IntPtr.Zero);
			this.vbox2.Add (this.showRadioButton);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.showRadioButton]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.movieRadioButton = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Movie"));
			this.movieRadioButton.CanFocus = true;
			this.movieRadioButton.Name = "movieRadioButton";
			this.movieRadioButton.DrawIndicator = true;
			this.movieRadioButton.UseUnderline = true;
			this.movieRadioButton.Group = this.showRadioButton.Group;
			this.vbox2.Add (this.movieRadioButton);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.movieRadioButton]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			this.hbox3.Add (this.vbox2);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.vbox2]));
			w8.Position = 1;
			this.hbox1.Add (this.hbox3);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.hbox3]));
			w9.Position = 1;
			// Container child hbox1.Gtk.Box+BoxChild
			this.popularButton = new global::Gtk.Button ();
			w4.SetTip (this.popularButton, "Get most popular shows from the active source", "Get most popular shows from the active source");
			this.popularButton.CanFocus = true;
			this.popularButton.Name = "popularButton";
			this.popularButton.UseUnderline = true;
			this.popularButton.Label = global::Mono.Unix.Catalog.GetString ("Popular");
			this.hbox1.Add (this.popularButton);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.popularButton]));
			w10.Position = 2;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.searchEntry = new global::Gtk.Entry ();
			this.searchEntry.CanFocus = true;
			this.searchEntry.Name = "searchEntry";
			this.searchEntry.IsEditable = true;
			this.searchEntry.InvisibleChar = '●';
			this.hbox4.Add (this.searchEntry);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.searchEntry]));
			w11.Position = 0;
			// Container child hbox4.Gtk.Box+BoxChild
			this.searchButton = new global::Gtk.Button ();
			this.searchButton.CanFocus = true;
			this.searchButton.Name = "searchButton";
			this.searchButton.UseUnderline = true;
			this.searchButton.Label = global::Mono.Unix.Catalog.GetString ("Search");
			this.hbox4.Add (this.searchButton);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.searchButton]));
			w12.Position = 1;
			w12.Expand = false;
			w12.Fill = false;
			this.hbox1.Add (this.hbox4);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.hbox4]));
			w13.Position = 3;
			this.container.Add (this.hbox1);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.container [this.hbox1]));
			w14.Position = 1;
			w14.Expand = false;
			w14.Fill = false;
			this.Add (this.container);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 673;
			this.DefaultHeight = 533;
			this.Show ();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
			this.BrowserSetUpAction.Activated += new global::System.EventHandler (this.OnBrowserSetUpSelected);
			this.AboutAction.Activated += new global::System.EventHandler (this.OnAboutSelected);
			this.backButton.Clicked += new global::System.EventHandler (this.OnBackButtonClicked);
			this.sourceComboBox.Changed += new global::System.EventHandler (this.OnSourceChanged);
			this.popularButton.Clicked += new global::System.EventHandler (this.OnPopButtonClicked);
			this.searchEntry.Changed += new global::System.EventHandler (this.OnSearchEntryChanged);
			this.searchButton.Clicked += new global::System.EventHandler (this.OnSearchButtonClicked);
		}
	}
}
