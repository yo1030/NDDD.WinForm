using System.Configuration;

namespace NDDD.Domain
{
    /// <summary>
    /// Shared
    /// </summary>
    public static class Shared
    {
        /// <summary>
        /// FakeのときTrue
        /// </summary>
        public static bool IsFake { get; } = ConfigurationManager.AppSettings["IsFake"] == "1";
        /// <summary>
        /// Fakeのpath
        /// </summary>
        public static string FakePath { get; } = ConfigurationManager.AppSettings["FakePath"];

        /// <summary>
        /// ログインID
        /// </summary>
        public static string LoginId { get; set; } = string.Empty;
    }
}
