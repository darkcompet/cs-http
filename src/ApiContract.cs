#pragma warning disable IDE0161 // 範囲指定されたファイルが設定された namespace に変換

namespace Tool.Compet.Http {
	using System.Text.Json.Serialization;

	/// Api response body.
	public class DkApiResponse {
		/// <summary>
		/// Status. For eg,. 200, 201, 400, 401, 404, 500, 501,...
		/// </summary>
		[JsonPropertyName("status")]
		public virtual int status { get; set; }

		/// <summary>
		/// Code (for both success and failure cases).
		/// For eg,. "should_retry", "need_more_coin",...
		/// </summary>
		[JsonPropertyName("code")]
		public virtual string? code { get; set; }

		/// <summary>
		/// Detail message for both success and failure cases.
		/// </summary>
		[JsonPropertyName("msg")]
		public virtual string? msg { get; set; }
	}
}
