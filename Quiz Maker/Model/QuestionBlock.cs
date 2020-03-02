﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Quiz_Maker.Model
{
    [Serializable]
    public class QuestionBlock
    {
        [XmlAttribute]
        public int id { get; set; }
        [XmlElement]
        public string Text { get; set; }
        [XmlArray]
        public List<Answer> Answers { get; set; }
    }    
}