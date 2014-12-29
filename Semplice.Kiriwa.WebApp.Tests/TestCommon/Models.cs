using System;
using System.Collections.Generic;
using Semplice.Kiriwa.Domains;
using Semplice.Kiriwa.Domains.DTOs;

namespace Semplice.Kiriwa.WebApp.Tests.TestCommon
{
    internal class Models
    {
        internal static List<StackWithCardCountDTO> StackWithCardCountDTOs
        {
            get
            {
                return new List<StackWithCardCountDTO>
                {
                    StackWithCardCountDTO
                };
            }
        }

        internal static StackWithCardCountDTO StackWithCardCountDTO
        {
            get
            {
                return new StackWithCardCountDTO
                {
                    CardCount = 1,
                    Stacks = Models.StackWithOneCard
                };
            }
        }

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
                            Title = "Unit Test Card 1 Title",
                            Text = "Unit Test Card 1 Text",
                            Created = DateTime.Now
                        }
                    }
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
                    Text = "Unit Test Card 2 Text",
                    Title = "Unit Test Card 2 Title"
                };
            }
        }
    }
}
