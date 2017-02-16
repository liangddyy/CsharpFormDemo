using System;
using Demo.business;

namespace Demo.model
{
    public class Content
    {
        private int cid;//隐 id 自增
        private String title;
        private String slug;//显示id
        private int created;
        private int modified;
        private String text;
        private int order;
        private int authorId ;
        private String template;
        private String type;//post 文章 page 页面
        private String status;
        private char allowComment;
        private char allowPing;
        private char allowFeed;

        /// <summary>
        /// 初始化
        /// 默認 作者1
        /// 默認 允许评论 允许ping 允许订阅
        /// </summary>
        public Content()
        {
            //初始化时间戳和作者
            this.created = Tools.getDateStampNow();
            this.modified = Tools.getDateStampNow();
            this.authorId = 1;
            this.AllowComment = '1';
            this.AllowPing = '1';
            this.AllowFeed = '1';
        }

        public int Cid
        {
            get { return cid; }
            set { cid = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Slug
        {
            get { return slug; }
            set { slug = value; }
        }

        public int Created
        {
            get { return created; }
            set { created = value; }
        }

        public int Modified
        {
            get { return modified; }
            set { modified = value; }
        }

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        public int Order
        {
            get { return order; }
            set { order = value; }
        }

        public int AuthorId
        {
            get { return authorId; }
            set { authorId = value; }
        }

        public string Template
        {
            get { return template; }
            set { template = value; }
        }

        public string Type1
        {
            get { return type; }
            set { type = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public char AllowComment
        {
            get { return allowComment; }
            set { allowComment = value; }
        }

        public char AllowPing
        {
            get { return allowPing; }
            set { allowPing = value; }
        }

        public char AllowFeed
        {
            get { return allowFeed; }
            set { allowFeed = value; }
        }
    }
}