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
