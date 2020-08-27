# AZ-204 - Developing Solutions for Microsoft Azure

These are resources for the AZ-204 exam by Microsoft I've found while studying to take the exam myself.

Based on comments from past test takers, it is best to study the Microsoft Learning path as a base, then expand to other options for more details. The Thomas Mauerer guide has good reviews online and the Pluralsight path can be beneficial given enough time.

The Whizlab tests can be gotten for as little as $5 on sale, which happens frequently, and provide at least four interactive practice tests that provide detailed explanations for every answer. If on a budget, the ExamTopics.com practice test will do fine, but isn't quite as interactive. As far as the courses on Whizlabs go, I purchased them but didn't use them in the end, the quality was slightly lower, and they were mostly labs of watching someone set up resources. This may have been beneficial, but without watching them again after the exam I can't say for certain.

I can't speak to the efficacy of the official Microsoft practice test from MindHub, since it has a hefty price tag on it. I would assume it is good quality, but I haven't heard of many people purchasing it and enjoying it; it also has an abyssmal two-star rating on the MinHub website as of the writing of this guide.

Udemy offers several courses and practice tests, but I can't speak to their quality either. I have heard that some are not helpful, but their ratings on the site are excellent. _Note: Never buy anything full price on Udemy. There is almost always a sale going on, so just wait a few days for the next one if you can_.

Finally, while not listed here, __you should study the official documentation itself__, as it can provide a lot of insight. See the Thomas Mauerer guide for some specific topics you can read.

- __[Microsoft Learning Path](https://docs.microsoft.com/en-us/learn/certifications/azure-developer)__
- [Quizlet Flash Cards (Created by me)](https://quizlet.com/_8lt96b?x=1jqt&i=mwv9z)
- [Thomas Mauerer Study Guide](https://www.thomasmaurer.ch/2020/03/az-204-study-guide-developing-solutions-for-microsoft-azure/)
- [Pluralsight Path](https://go.pluralsight.com/C0089710)
- [Labs Github](https://github.com/MicrosoftLearning/AZ-204-DevelopingSOlutionsforMicrosoftAzure)
- [Whizlabs Practice Test (and Course)](https://www.whizlabs.com/learn/course/microsoft-azure-az-204/)
- [ExamTopics.com Practice Test](https://www.examtopics.com/exams/microsoft/az-204)
- [Official Microsoft Practice Test](https://www.mindhub.com/az-204-developing-solutions-for-microsoft-azure-microsoft-official-practice-test/p/MU-AZ-204)
- [Multiple Udemy Topics](https://www.udemy.com/topic/microsoft-az-204/)

As of the writing of this guide, ACloudGuru.com does not yet have an official course for the AZ-204 but it is being actively developed.

## How is the test broken down?

According to Thomas Mauerer, the test is broken down by the following sections:

| Topic | Portion of Test Questions |
| ----- | ------------------------- |
| Azure Compute | 25-30% |
| Azure Storage | 10-15% |
| Azure Security | 15-20% |
| Monitor, troubleshoot, and optimize | 10-15% |
| Connect and consume Azure services and third-party services | 25-30% |

On his blog post, he breaks down the Microsoft documentation into the relevant sections for you, so I would recommend checking that out.

## CLI Test Tool

From what I saw in most study guides and practice exams, there was a particular emphasis on the Azure CLI and PowerShell commands. So for practice I created a simple .NET Console application that quizzed me on those commnands (for the CLI, I didn't create one for PS). Feel free to utilize this tool, and even submit a pull request to add more questions or a PowerShell version!

It can be located in the `cli-test` directory, and will require the .NET Core SDK to run.

## After the Exam Thoughts

I took the Exam on August 28, 2020 and passed. The breakdown above was pretty accurate, but I think particular attention should be paid to the last bullet "Connect and consume Azure services and third-party services". There were a lot of topics relating the Event Hubs, Event Grid, Service Bus, and Storage Queues. It's important to know which one to use when, and how they interact with each other and other Azure services. You should also know how to create and update Azure services by using the CLI. Finally, it is helpful to create some test code for each application, another skill you should have is the ability to work with the SDKs for a particular resource; I don't think you need to know a particular language's implementation, since they should all be named the same with different capitalization.

I think the study method that helped me the most was the Skillpipe provided with my instructor-led course. I can't speak to the efficacy of the instructor, but the Skillpipe broke the topics down into helpful chapters and used friendlier verbage so it was easier to understand that just reading the Microsoft Docs alone. However, unless you take the course you won't have access to that, so the Microsoft Docs will do just fine, just may be harder to decide which sections to read and which to skip. One common thread in all my practice tests was that a lot of the example questions were taken directly out of the Microsoft Docs, especially examples of code snippets.

As far as practice tests go, I would recommend the Whizlabs tests. There are six tests that I was able to take gradually over the course of my learning and check my progress with. You can take the tests multiple times, and after each test, the answers are spelled out with a link to the documentation. There were some lower quality questions and the grammar wasn't always on point, but they were still helpful because they introduced me to important concepts I otherwise might have skipped in the documentation.

Finally, the Quizlet flashcards I created turned out to be very helpful. There was a close association between the topics I put on the card and some of the topics that came up on the test. See above for a link to those and all the other resources I've mentioned here.
