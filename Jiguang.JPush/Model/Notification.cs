﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace Jiguang.JPush.Model
{
    /// <summary>
    /// <see cref="https://docs.jiguang.cn/jpush/server/push/rest_api_v3_push/#notification"/>
    /// </summary>
    public class Notification
    {
        [JsonProperty("alert")]
        public string Alert { get; set; }

        [JsonProperty("android", NullValueHandling = NullValueHandling.Ignore)]
        public Android Android { get; set; }

        [JsonProperty("ios", NullValueHandling = NullValueHandling.Ignore)]
        public IOS IOS { get; set; }
    }

    public class Android
    {
        [JsonProperty("alert")]
        public string Alert { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("builder_id")]
        public int BuilderId { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("style")]
        public int Style { get; set; }

        [JsonProperty("alert_type")]
        public int AlertType { get; set; }

        [JsonProperty("big_text")]
        public string BigText { get; set; }

        [JsonProperty("inbox")]
        public Dictionary<string, object> Inbox { get; set; }

        [JsonProperty("big_pic_path")]
        public string BigPicturePath { get; set; }

        [JsonProperty("extras")]
        public Dictionary<string, object> Extras { get; set; }

        /// <summary>
        /// 指定开发者想要打开的 Activity，值为 <activity> 节点的 "android:name" 属性值。
        /// </summary>
        [JsonProperty("url_activity")]
        public string URIActivity { get; set; }

        /// <summary>
        /// 指定打开 Activity 的方式，值为 Intent.java 中预定义的 "access flags" 的取值范围。
        /// </summary>
        [JsonProperty("url_flag")]
        public string URIFlag { get; set; }

        /// <summary>
        /// 指定开发者想要打开的 Activity，值为 <activity> -> <intent-filter> -> <action> 节点中的 "android:name" 属性值。
        /// </summary>
        [JsonProperty("uri_action")]
        public string URIAction { get; set; }
    }

    public class IOS
    {
        /// <summary>
        /// 可以是 string，也可以是 Apple 官方定义的 alert payload 结构。
        /// <para><see ="https://developer.apple.com/library/content/documentation/NetworkingInternet/Conceptual/RemoteNotificationsPG/PayloadKeyReference.html#//apple_ref/doc/uid/TP40008194-CH17-SW5"/></para>
        /// </summary>
        [JsonProperty("alert")]
        public object Alert { get; set; }

        [JsonProperty("sound")]
        public string Sound { get; set; }

        [JsonProperty("badge")]
        public string Badge { get; set; } = "+1";

        [JsonProperty("content-available")]
        public bool ContentAvailable { get; set; }

        [JsonProperty("mutable-content")]
        public bool MutableContent { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("extras")]
        public Dictionary<string, object> Extras { get; set; }
    }
}
