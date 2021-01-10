
using MultiLanguageWindowsForm.Language.MultiLang;

namespace MultiLanguageWindowsForm.Language
{
    class ChoseLanguage
    {
        private readonly Bangla _bangla=new Bangla();
        private readonly English _english=new English();

        public LangProperty Lang=new LangProperty();

        public void Language(string language)
        {
            switch (language)
            {
                case "Bangla":
                    _bangla.Line();
                    Lang = _bangla.LangProperty;
                    break;
                case "English":
                    _english.Line();
                    Lang = _english.LangProperty;
                    break;
            }
        }

    }
}
