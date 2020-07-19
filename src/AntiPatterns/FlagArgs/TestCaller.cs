using NUnit.Framework;

namespace AntiPatterns.FlagArgs
{
    public class TestCaller
    {
        // --------------------------------------------------
        // アンチパターン呼び出し
        // --------------------------------------------------

        [Test]
        public void CallAntiPattern1()
        {
            // ==================================================
            // # Bad Point :(
            //
            //   - コードを見ただけでは引数の意味がわからない
            //
            // ==================================================

            var api = new AntiPattern_Api();
            var msg = api.FetchMessage(false);

            Assert.Pass();
        }

        [Test]
        public void CallAntiPattern2()
        {
            // ==================================================
            // -> CallAntiPattern1を改善するために引数を変数にした
            //
            // # Bad Point :(
            //
            //   - たとえばメッセージを保存している箇所を特定したいとき
            //     FetchMessageの呼び出し元を検索すると以下のようになる
            //
            //     [検索結果]:
            //         var msg = antiPattern.FetchMessage(saveFlag);
            //
            //     この一行だけでは saveFlag が true か false か不明であり
            //     呼び出し元のコード（このコード）を追う必要がある
            //
            //     - しかもこれが同様にフラグ引数で渡されていると
            //       さらに呼び出し元を追っていく必要がある（だが、よくある）
            //
            // ==================================================

            var api = new AntiPattern_Api();
            bool saveFlag = true;
            var msg = api.FetchMessage(saveFlag);

            Assert.Pass();
        }

        // --------------------------------------------------





        // ++++++++++++++++++++++++++++++++++++++++++++++++++
        // リファクタリング後呼び出し
        // ++++++++++++++++++++++++++++++++++++++++++++++++++

        [Test]
        public void CallRefactored()
        {
            // ==================================================
            // # Good Point :)
            //
            //   - 読みやすい
            //
            //   - たとえばメッセージを保存している箇所を特定したい場合は
            //     SaveMessageメソッドの参照を検索するだけで良い
            //
            // ==================================================

            var api = new Refactored_Api();
            var msg = api.FetchMessage();

            var storage = new Refactored_Storage();
            storage.SaveMessage(msg);

            Assert.Pass();
        }

        // ++++++++++++++++++++++++++++++++++++++++++++++++++


    }

}