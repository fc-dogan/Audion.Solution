﻿// <auto-generated />
using System;
using AudionApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AudionApi.Migrations
{
    [DbContext(typeof(AudionApiContext))]
    partial class AudionApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AudionApi.Models.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Text")
                        .IsRequired();

                    b.HasKey("QuestionId");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            QuestionId = 1,
                            Text = "What’s one thing you wish you knew how to do?"
                        },
                        new
                        {
                            QuestionId = 2,
                            Text = "What is something that you would change about yourself spiritually or emotionally?"
                        },
                        new
                        {
                            QuestionId = 3,
                            Text = "What’s been your biggest mistake so far in life and what did you learn from it?"
                        },
                        new
                        {
                            QuestionId = 4,
                            Text = "Which parent are you closer to and why?"
                        },
                        new
                        {
                            QuestionId = 5,
                            Text = "What was your favorite pastime as a young child?"
                        },
                        new
                        {
                            QuestionId = 6,
                            Text = "What is the first life changing moment that comes to your mind?"
                        },
                        new
                        {
                            QuestionId = 7,
                            Text = "What was the best phase in your life?"
                        },
                        new
                        {
                            QuestionId = 8,
                            Text = "What was the worst phase in your life?"
                        },
                        new
                        {
                            QuestionId = 9,
                            Text = "Is what you’re doing now what you always wanted to do growing up? If not, then what did you always dream of doing as a child?"
                        },
                        new
                        {
                            QuestionId = 10,
                            Text = "What is the best vacation you have ever been on?"
                        },
                        new
                        {
                            QuestionId = 11,
                            Text = "What’s your favorite book/movie of all time and why did it speak to you so much?"
                        },
                        new
                        {
                            QuestionId = 12,
                            Text = "What is a relationship deal breaker for you?"
                        },
                        new
                        {
                            QuestionId = 13,
                            Text = "What is your favorite physical feature about people who you are attracted to?"
                        },
                        new
                        {
                            QuestionId = 14,
                            Text = "Is forgiveness important to you, or do you think that it is better to hold grudges?"
                        },
                        new
                        {
                            QuestionId = 15,
                            Text = "When do you think a person is ready for marriage?"
                        },
                        new
                        {
                            QuestionId = 16,
                            Text = "Who is that one person you can talk to about just anything?"
                        },
                        new
                        {
                            QuestionId = 17,
                            Text = "Where is your favorite place in the entire world to go?"
                        },
                        new
                        {
                            QuestionId = 18,
                            Text = "Do you usually stay friends with your exes?"
                        },
                        new
                        {
                            QuestionId = 19,
                            Text = "How many serious relationships have you had up until this point?"
                        },
                        new
                        {
                            QuestionId = 20,
                            Text = "Have you ever lost someone close to you? If so , who and when?"
                        },
                        new
                        {
                            QuestionId = 21,
                            Text = "If you are in a bad mood, do you prefer to be left alone or have someone to cheer you up?"
                        },
                        new
                        {
                            QuestionId = 22,
                            Text = "What is the best way to cheer you up on a bad day?"
                        },
                        new
                        {
                            QuestionId = 23,
                            Text = "What’s an ideal weekend for you?"
                        },
                        new
                        {
                            QuestionId = 24,
                            Text = "What do you think of best friends of the opposite sex?"
                        },
                        new
                        {
                            QuestionId = 25,
                            Text = "Do you judge a book by its cover?"
                        },
                        new
                        {
                            QuestionId = 26,
                            Text = "What was your very first job?"
                        },
                        new
                        {
                            QuestionId = 27,
                            Text = "What are your hobbies that you like to do alone?"
                        },
                        new
                        {
                            QuestionId = 28,
                            Text = "Do you believe in second chances? Would you give a third chance? Where is your cut off on new chances?"
                        },
                        new
                        {
                            QuestionId = 29,
                            Text = "What’s the one thing that people always misunderstand about you?"
                        },
                        new
                        {
                            QuestionId = 30,
                            Text = "What did your past relationship teach you?"
                        });
                });

            modelBuilder.Entity("AudionApi.Models.Response", b =>
                {
                    b.Property<int>("ResponseId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Ethnicity");

                    b.Property<string>("Gender");

                    b.Property<bool>("Parent");

                    b.Property<int>("QuestionId");

                    b.Property<string>("Region");

                    b.Property<string>("Text");

                    b.Property<DateTime>("Timestamp");

                    b.HasKey("ResponseId");

                    b.HasIndex("QuestionId");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            ResponseId = 1,
                            Age = 1,
                            Ethnicity = "White",
                            Gender = "Male",
                            Parent = true,
                            QuestionId = 2,
                            Region = "Northwest",
                            Text = "Test Response of Question 2",
                            Timestamp = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ResponseId = 2,
                            Age = 2,
                            Ethnicity = "Black",
                            Gender = "Male",
                            Parent = true,
                            QuestionId = 5,
                            Region = "Southwest",
                            Text = "Test Response of Question 5",
                            Timestamp = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ResponseId = 3,
                            Age = 2,
                            Ethnicity = "Latino",
                            Gender = "Female",
                            Parent = true,
                            QuestionId = 5,
                            Region = "Northwest",
                            Text = "Test Response of Question 5",
                            Timestamp = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ResponseId = 4,
                            Age = 2,
                            Ethnicity = "Latino",
                            Gender = "Female",
                            Parent = false,
                            QuestionId = 3,
                            Region = "Southwest",
                            Text = "Test Response of Question 3",
                            Timestamp = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ResponseId = 5,
                            Age = 2,
                            Ethnicity = "White",
                            Gender = "Female",
                            Parent = true,
                            QuestionId = 3,
                            Region = "Southwest",
                            Text = "Test Response of Question 3",
                            Timestamp = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ResponseId = 6,
                            Age = 1,
                            Ethnicity = "Black",
                            Gender = "Male",
                            Parent = true,
                            QuestionId = 3,
                            Region = "Southeast",
                            Text = "Test Response of Question 3",
                            Timestamp = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ResponseId = 7,
                            Age = 3,
                            Ethnicity = "Latino",
                            Gender = "Female",
                            Parent = true,
                            QuestionId = 6,
                            Region = "Southwest",
                            Text = "Test Response of Question 6",
                            Timestamp = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ResponseId = 8,
                            Age = 2,
                            Ethnicity = "Asian",
                            Gender = "Female",
                            Parent = true,
                            QuestionId = 6,
                            Region = "Northwest",
                            Text = "Test Response of Question 6",
                            Timestamp = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ResponseId = 9,
                            Age = 3,
                            Ethnicity = "Latino",
                            Gender = "Female",
                            Parent = true,
                            QuestionId = 6,
                            Region = "Southeast",
                            Text = "Test Response of Question 6",
                            Timestamp = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("AudionApi.Models.Response", b =>
                {
                    b.HasOne("AudionApi.Models.Question")
                        .WithMany("Responses")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
