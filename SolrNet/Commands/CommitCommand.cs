namespace SolrNet {
	public class CommitCommand : ISolrCommand {
		private bool waitFlush = true;
		private bool waitSearcher = true;

		public bool WaitFlush {
			get { return waitFlush; }
			set { waitFlush = value; }
		}

		public bool WaitSearcher {
			get { return waitSearcher; }
			set { waitSearcher = value; }
		}

		public string Execute(ISolrConnection connection) {
			return connection.Post(
				string.Format("<commit waitFlush=\"{0}\" waitSearcher=\"{1}\"/>",
				              waitFlush.ToString().ToLower(),
				              waitSearcher.ToString().ToLower()));
		}
	}
}