﻿using System;
using System.Collections.Generic;
using Semplice.Kiriwa.Domains;

namespace Semplice.Kiriwa.SL.Tests.TestCommon
{
    internal class Models
    {
        internal static Stack StackWithOneCard
        {
            get
            {
                return new Stack
                {
                    StackId = 1,
                    Name = "Unit Test Stack 1 Name",
                    Created = DateTime.Now,
                    Description = "Unit Test Stack 1 Description",
                    Cards = new HashSet<Card>
                    {
                        new Card
                        {
                            CardId = 1,
                            FrontTitle = "Unit Test Card 1 Title",
                            FrontText = "Unit Test Card 1 Text",
                            Created = DateTime.Now
                        }
                    }
                };
            }
        }

        internal static Stack StackWithoutChildren
        {
            get
            {
                return new Stack
                {
                    StackId = 2,
                    Name = "Unit Test Stack 2 Name",
                    Created = DateTime.Now,
                    Description = "Unit Test Stack 2 Description"
                };
            }
        }

        internal static Card CardWithoutChildren
        {
            get
            {
                return new Card
                {
                    CardId = 2,
                    Created = DateTime.Now,
                    FrontText = "Unit Test Card 2 Text",
                    FrontTitle = "Unit Test Card 2 Title"
                };
            }
        }
    }
}
