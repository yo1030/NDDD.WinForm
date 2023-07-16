using System;

namespace NDDD.Domain.Exceptions
{
    /// <summary>
    /// Fake例外
    /// </summary>
    public sealed class FakeException : ExceptionBase
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="message">メッセージ</param>
        /// <param name="ex">元になった例外</param>
        public FakeException(string message, Exception ex)
            :base(message, ex)
        {
            
        }

        /// <summary>
        /// 例外区分
        /// </summary>
        public override ExceptionKind Kind => ExceptionKind.Error;
    }
}
