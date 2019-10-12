namespace YackeenBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedSomeDummyArticles : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[Articles] ([CategoryId],[Title],[Content],[CreatedBy],[CreatedOn])
                VALUES (N'2',N'Real Madrid Back To La Liga Race',

                N'Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin
                literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College
                in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through
                the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32
                and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a
                treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, Lorem ipsum dolor sit',

                N'c27ca609-a547-407d-9846-ad45b2f8a1fd',N'2019-10-12T00:00:00.000')");

            Sql(@"INSERT INTO [dbo].[Articles] ([CategoryId],[Title],[Content],[CreatedBy],[CreatedOn])
                VALUES (N'2',N'Liverpool On Fire',

                N'Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin
                literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College
                in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through
                the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32
                and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a
                treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, Lorem ipsum dolor sit',

                N'c27ca609-a547-407d-9846-ad45b2f8a1fd',N'2019-10-12T00:00:00.000')");

            Sql(@"INSERT INTO [dbo].[Articles] ([CategoryId],[Title],[Content],[CreatedBy],[CreatedOn])
                VALUES (N'3',N'Syria Under Massive Attack',

                N'Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin
                literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College
                in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through
                the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32
                and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a
                treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, Lorem ipsum dolor sit',

                N'c27ca609-a547-407d-9846-ad45b2f8a1fd',N'2019-10-12T00:00:00.000')");

            Sql(@"INSERT INTO [dbo].[Articles] ([CategoryId],[Title],[Content],[CreatedBy],[CreatedOn])
                VALUES (N'3',N'Donald Trump ? Is it the End !',

                N'Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin
                literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College
                in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through
                the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32
                and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a
                treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, Lorem ipsum dolor sit',

                N'c27ca609-a547-407d-9846-ad45b2f8a1fd',N'2019-10-12T00:00:00.000')");

            Sql(@"INSERT INTO [dbo].[Articles] ([CategoryId],[Title],[Content],[CreatedBy],[CreatedOn])
                VALUES (N'3',N'The Brexit Side Effects',

                N'Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin
                literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College
                in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through
                the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32
                and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a
                treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, Lorem ipsum dolor sit',

                N'c27ca609-a547-407d-9846-ad45b2f8a1fd',N'2019-10-12T00:00:00.000')");

            Sql(@"INSERT INTO [dbo].[Articles] ([CategoryId],[Title],[Content],[CreatedBy],[CreatedOn])
                VALUES (N'7',N'Microsoft Introduce Blazor',

                N'Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin
                literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College
                in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through
                the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32
                and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a
                treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, Lorem ipsum dolor sit',

                N'c27ca609-a547-407d-9846-ad45b2f8a1fd',N'2019-10-12T00:00:00.000')");

            Sql(@"INSERT INTO [dbo].[Articles] ([CategoryId],[Title],[Content],[CreatedBy],[CreatedOn])
                VALUES (N'7',N'The Truth About Vegans',

                N'Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin
                literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College
                in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through
                the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32
                and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a
                treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, Lorem ipsum dolor sit',

                N'c27ca609-a547-407d-9846-ad45b2f8a1fd',N'2019-10-12T00:00:00.000')");

            Sql(@"INSERT INTO [dbo].[Articles] ([CategoryId],[Title],[Content],[CreatedBy],[CreatedOn])
                VALUES (N'7',N'Nobel For The 72 Years Old',

                N'Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin
                literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College
                in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through
                the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32
                and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a
                treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, Lorem ipsum dolor sit',

                N'c27ca609-a547-407d-9846-ad45b2f8a1fd',N'2019-10-12T00:00:00.000')");

            Sql(@"INSERT INTO [dbo].[Articles] ([CategoryId],[Title],[Content],[CreatedBy],[CreatedOn])
                VALUES (N'2',N'Ronaldo Scores The 699th Goal !',

                N'Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin
                literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College
                in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through
                the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32
                and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a
                treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, Lorem ipsum dolor sit',

                N'c27ca609-a547-407d-9846-ad45b2f8a1fd',N'2019-10-12T00:00:00.000')");

            Sql(@"INSERT INTO [dbo].[Articles] ([CategoryId],[Title],[Content],[CreatedBy],[CreatedOn])
                VALUES (N'4',N'The Joker Vs The Irish Man',

                N'Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin
                literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College
                in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through
                the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32
                and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a
                treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, Lorem ipsum dolor sit',

                N'c27ca609-a547-407d-9846-ad45b2f8a1fd',N'2019-10-12T00:00:00.000')");

            Sql(@"INSERT INTO [dbo].[Articles] ([CategoryId],[Title],[Content],[CreatedBy],[CreatedOn])
                VALUES (N'4',N'Top Hits 2019 Around The World',

                N'Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin
                literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College
                in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through
                the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32
                and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a
                treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, Lorem ipsum dolor sit',

                N'c27ca609-a547-407d-9846-ad45b2f8a1fd',N'2019-10-12T00:00:00.000')");

        }

        public override void Down()
        {
            Sql(@"DELETE FROM [dbo].[Articles]");

        }
    }
}
