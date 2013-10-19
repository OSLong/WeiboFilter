﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Silver6wings.LabClassifier.Classifiers
{
	abstract class Transmitter
    {
        public Strategy _strategy { get; internal set; }    // 自己所在的strategy
        public int _index { get; internal set; }            // 自己所在的strategy里transmitter list的位置       

        public abstract void receiveItem(string item, string category);

        public abstract void reportItem(string item, string category);
	}
}
