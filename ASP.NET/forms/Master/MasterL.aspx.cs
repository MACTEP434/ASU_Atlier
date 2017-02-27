﻿/*flexberryautogenerated="true"*/
namespace IIS.АСУ_Ателье
{
    using System;
    using ICSSoft.STORMNET.Web.Controls;

    using Resources;

    public partial class МастерL : BaseListForm<Мастер>
    {
        /// <summary>
        /// Конструктор без параметров,
        /// инициализирует свойства, соответствующие конкретной форме.
        /// </summary>
        public МастерL() : base(Мастер.Views.МастерL)
        {
            EditPage = МастерE.FormPath;
        }
                
        /// <summary>
        /// Путь до формы.
        /// </summary>
        public static string FormPath
        {
            get { return "~/forms/Master/MasterL.aspx"; }
        }

        /// <summary>
        /// Вызывается самым первым в Page_Load.
        /// </summary>
        protected override void Preload()
        {
        }

        /// <summary>
        /// Вызывается самым последним в Page_Load.
        /// </summary>
        protected override void Postload()
        {
        }
    }
}
