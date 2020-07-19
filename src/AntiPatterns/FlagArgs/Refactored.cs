namespace AntiPatterns.FlagArgs
{
    // ++++++++++++++++++++++++++++++++++++++++++++++++++
    // # リファクタリング
    //   1. やることを複数のクラスやメソッドに分割する
    //   2. 呼び出し側で分割したメソッドを必要に応じて呼び出す
    // ++++++++++++++++++++++++++++++++++++++++++++++++++

    public class Refactored_Api
    {
        /// <summary>
        /// メッセージを取得する
        /// </summary>
        /// <returns>取得したメッセージ</returns>
        public string FetchMessage()
        {
            /* ==============================
             * [メッセージを取得する] コード
             * ============================== */
            string msg = "取得したメッセージ";
            return msg;
        }

    }


    public class Refactored_Storage
    {
        /// <summary>
        /// メッセージを保存する
        /// </summary>
        /// <param name="msg">メッセージ</param>
        public void SaveMessage(string msg)
        {
            /* ==============================
             * [メッセージをファイルに保存する] コード
             * ============================== */
        }

    }


}
