﻿// The MIT License (MIT)
//
// Copyright (c) 2009 - 2018 Lightbend Inc.
// Copyright (c) 2013 - 2018 .NET Foundation
// Modified from original source https://github.com/akkadotnet/akka.net
//
// Copyright (c) 2018 - 2019 Lutando Ngqakaza
// https://github.com/Lutando/Akkatecture 
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of
// this software and associated documentation files (the "Software"), to deal in
// the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do so,
// subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
// FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
// COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
// IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
// CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using System;

namespace Akka.MultiNodeTestRunner.Shared.Persistence
{
    public class TimelineItem
    {
        private const string EventFormat = "{{ className:'{0}', content:'{1}', start:'{2}', group:{3}, title:'{4}' }}";

        public TimelineItem(string cssClass, string content, string title, DateTime dateTime, int groupId)
        {
            Classname = cssClass;
            Content = content;
            Start = dateTime;
            GroupId = groupId;
            Title = title;
        }

        public string Classname { get; private set; }

        public string Content { get; private set; }

        public string Title { get; private set; }

        public DateTime Start { get; private set; }

        public int GroupId { get; private set; }

        public string ToJavascriptString()
        {
            return string.Format(EventFormat, Classname, Content, Start.ToString("o"), GroupId, Title);
        }
    }
}
