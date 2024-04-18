#pragma warning disable IDE0161 // 範囲指定されたファイルが設定された namespace に変換

namespace Tool.Compet.Http {
	/// Api response body.
	public class DkApiResponse {
		/// Status.
		/// For eg,. 200, 201, 400, 401, 404, 500, 501,...
		public virtual int status { get; set; }

		/// Code (for both success and failure cases).
		/// For eg,. "should_retry", "need_more_coin",...
		public virtual string? code { get; set; }

		/// Detail message for both success and failure cases.
		public virtual string? msg { get; set; }
	}
}
