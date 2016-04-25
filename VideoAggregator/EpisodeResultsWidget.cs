﻿using System;

namespace VideoAggregator
{
	//[System.ComponentModel.ToolboxItem (true)]
	public class EpisodeResultsWidget : EmbeddedWidget
	{
		private Season season;
		public EpisodeResultsWidget (MainWindow parent, Season season, int start) : base()
		{
			this.parent = parent;
			this.season = season;
			this.start = start;

			this.Build ();
			this.ShowAll ();

			if (season.episodes.Count <= start + 25)
				loadMoreButton.Destroy ();
			Console.WriteLine ("EpisodeResultsWindow Created");
		}

		protected new void Build ()
		{
			this.Name = "EpisodeResultsWidget";
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			initTable ();
			populateTable ();
		}

		protected void populateTable(){
			int curEpisode = start;
			for (uint i = 0; i < 5; i++) {
				if (curEpisode >= season.episodes.Count)
					break;

				for (uint j = 0; j < 5; j++) {
					if (curEpisode >= season.episodes.Count)
						break;

					Gtk.Image img = new Gtk.Image();
					if (season.episodes[curEpisode].thumb != null)
						img.Pixbuf = season.episodes[curEpisode].thumb;

					Gtk.Label lbl = new Gtk.Label ((curEpisode+1).ToString() + ". " + season.episodes[curEpisode].title);
					Gtk.VBox box = new Gtk.VBox ();
					box.Add (img);
					box.Add (lbl);
					Gtk.EventBox eventbox = new Gtk.EventBox ();
					eventbox.Add (box);

					Func<Episode, Gtk.ButtonPressEventHandler> ButtonPressWrapper = ((ep) => ((s, e) => { OnEpisodeSelected(s, e, ep); }));
					eventbox.ButtonPressEvent += ButtonPressWrapper(season.episodes[curEpisode]);

					Func<Gtk.EventBox, Gtk.EnterNotifyEventHandler> EnterNotifyWrapper = ((Gtk.EventBox eBox) => ((s, e) => {OnHoverEnter(s,e,eBox);}));
					eventbox.EnterNotifyEvent += EnterNotifyWrapper(eventbox);

					Func<Gtk.EventBox, Gtk.LeaveNotifyEventHandler> LeaveNotifyWrapper = ((Gtk.EventBox eBox) => ((s, e) => {OnHoverLeave(s,e,eBox);}));
					eventbox.LeaveNotifyEvent += LeaveNotifyWrapper(eventbox);

					table.Attach (eventbox, j, j + 1, i, i + 1);

					curEpisode++;
				}
			}
		}

		protected void OnEpisodeSelected (object o, Gtk.ButtonPressEventArgs args, Episode ep)
		{
			parent.episodeSelected (ep);
		}

		protected override void OnLoadMoreClicked (object sender, EventArgs e)
		{
			parent.loadMoreResults (new EpisodeResultsWidget (parent, season, start + 25));
		}
	}
}

