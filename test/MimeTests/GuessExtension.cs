﻿using HeyRed.Mime;
using System.IO;
using Xunit;

namespace MimeTests
{
    public class GuessExtension
    {
        [Fact]
        public void GuessExtensionFromFilePath()
        {
            string expected = "jpeg";
            string actual = MimeGuesser.GuessExtension(ResourceUtils.TestDataPath);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GuessExtensionFromBuffer()
        {
            byte[] buffer = File.ReadAllBytes(ResourceUtils.TestDataPath);
            string expected = "jpeg";
            string actual = MimeGuesser.GuessExtension(buffer);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GuessExtensionFromStream()
        {
            using (var stream = File.OpenRead(ResourceUtils.TestDataPath))
            {
                string expected = "jpeg";
                string actual = MimeGuesser.GuessExtension(stream);

                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void GuessExtensionFromFileInfo()
        {
            string expected = "jpeg";
            var fi = new FileInfo(ResourceUtils.TestDataPath);
            string actual = fi.GuessExtension();

            Assert.Equal(expected, actual);
        }
    }
}
