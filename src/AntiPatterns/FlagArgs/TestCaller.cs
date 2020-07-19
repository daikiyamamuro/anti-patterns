using NUnit.Framework;

namespace AntiPatterns.FlagArgs
{
    public class TestCaller
    {
        // --------------------------------------------------
        // �A���`�p�^�[���Ăяo��
        // --------------------------------------------------

        [Test]
        public void CallAntiPattern1()
        {
            // ==================================================
            // # Bad Point :(
            //
            //   - �R�[�h�����������ł͈����̈Ӗ����킩��Ȃ�
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
            // -> CallAntiPattern1�����P���邽�߂Ɉ�����ϐ��ɂ���
            //
            // # Bad Point :(
            //
            //   - ���Ƃ��΃��b�Z�[�W��ۑ����Ă���ӏ�����肵�����Ƃ�
            //     FetchMessage�̌Ăяo��������������ƈȉ��̂悤�ɂȂ�
            //
            //     [��������]:
            //         var msg = antiPattern.FetchMessage(saveFlag);
            //
            //     ���̈�s�����ł� saveFlag �� true �� false ���s���ł���
            //     �Ăяo�����̃R�[�h�i���̃R�[�h�j��ǂ��K�v������
            //
            //     - ���������ꂪ���l�Ƀt���O�����œn����Ă����
            //       ����ɌĂяo������ǂ��Ă����K�v������i�����A�悭����j
            //
            // ==================================================

            var api = new AntiPattern_Api();
            bool saveFlag = true;
            var msg = api.FetchMessage(saveFlag);

            Assert.Pass();
        }

        // --------------------------------------------------





        // ++++++++++++++++++++++++++++++++++++++++++++++++++
        // ���t�@�N�^�����O��Ăяo��
        // ++++++++++++++++++++++++++++++++++++++++++++++++++

        [Test]
        public void CallRefactored()
        {
            // ==================================================
            // # Good Point :)
            //
            //   - �ǂ݂₷��
            //
            //   - ���Ƃ��΃��b�Z�[�W��ۑ����Ă���ӏ�����肵�����ꍇ��
            //     SaveMessage���\�b�h�̎Q�Ƃ��������邾���ŗǂ�
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