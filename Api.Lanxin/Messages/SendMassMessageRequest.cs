﻿using Api.Lanxin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Lanxin.Messages
{
    /// <summary>
    /// 群发消息消息体
    /// </summary>
    public class SendMassMessageRequest
    {
        #region private fields
        private Text _text;
        private Attachment _attachment;
        private Link _link;
        private News _news;
        private Mail _mail;
        //private MpNews _mpnews;

        private string _msgtype = "text";
        #endregion
        /// <summary>
        /// true:群发给整个组织;false:按照tousers、togroups群发
        /// </summary>
        public bool toall { get; set; }
        /// <summary>
        /// 多个接收方手机号
        /// </summary>
        public string[] tousers { get; set; }
        /// <summary>
        /// 多个接收方分支ID
        /// </summary>
        public string[] togroups { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string msgtype
        {
            get { return _msgtype; }
            set { _msgtype = value; }
        }
        /// <summary>
        /// 短信消息,是true,否false
        /// </summary>
        public bool sms { get; set; }
        /// <summary>
        /// 是否需要记录消息发送状态 0不记录(默认)，1记录
        /// </summary>
        public int needSendingState { get; set; }

        #region Extensions Propoties

        /// <summary>
        /// 文本消息
        /// </summary>
        public Text text
        {
            get { return _text; }
            set
            {
                _text = value;
                _msgtype = "text";
            }
        }
        /// <summary>
        /// 附件消息 支持图片、音频、视频、office文件等附件消息。msgtype = "attachment"
        /// </summary>
        public Attachment Attachment
        {
            get { return _attachment; }
            set
            {
                _attachment = value;
                _msgtype = "attachment";
            }
        }
        /// <summary>
        /// 链接消息
        /// </summary>
        public Link link
        {
            get { return _link; }
            set
            {
                _link = value;
                _msgtype = "link";
            }
        }
        /// <summary>
        /// 邮件消息
        /// </summary>
        public Mail mail
        {
            get { return _mail; }
            set
            {
                _mail = value;
                _msgtype = "mail";
            }
        }
        /// <summary>
        /// 图文消息条数限制在10条以内，注意，如果图文数超过10，则将会无响应。
        /// </summary>
        public News news
        {
            get { return _news; }
            set
            {
                _news = value;
                _msgtype = "news";
            }
        }
        #endregion
    }
}
