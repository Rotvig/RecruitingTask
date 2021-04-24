# Code Test
The code test for new applicants.

Read the task description thoroughly and create a fork with your solution.

## Task Description

### Log	Task

The task of creating a small log component has been given to you. The consultant that has been doing
the task is not in the company anymore, you might notice why when you investigate the code.

You are given the code as it is. Your task is to finish the component, fix any bugs and give it a good
architecture.

### Log Component

The component is a small DLL that can do asynchronous writing of strings to a file.

#### Demands

1. A call to Write on the interface must be as fast as possible so the calling application can get on with its
work without waiting for the log to be written to a file.
2. If we cross midnight a new file with the next day's timestamp must be made
3. It must be possible to stop the component in two ways:
    * Ask it to stop right away and if any outstanding logs exists, they will be discarded
    * Ask it to stop by waiting for it to finish writing existing outstanding logs
4. If an error occurs the calling application must attempt to recover. It's more important that the application recovers from errors, than a few logs being lost.


#### The following must be proven by unit tests

1. A call to LogInterface will end up in writing something
2. New files are created if midnight is crossed
3. The stop behavior is working as described above

#### Projects

**LogComponent.csproj**: This is the project containing all the logic around logging things.

The **LogInterface** is the public interface

**Application.csproj**: This project is the application using the LogComponent.

#### Your task

Your task is to make the log component do what is specified in the Demands section and create the
mentioned unit tests to prove it works.

#### Things to consider

* Is my code readable and easy to maintain? 
* Have I followed what I believe to be common coding standards?
* Have I identified and fixed potential bugs?
* How do I verify that the bugs were fixed and that my code works? 
* Does my solution live up to modern standard?

There are no limits in what you can do with the code. You can create new classes, new interfaces, use
other technologies within .Net as long as the LogComponent will do as specified. 
Feel free - actually we encourage you to rename, restructure and improve any classes, methods and variables you find!

You are also welcome to use any frameworks you choose. 

If you lack technical skills within any part of the task, you can write a textual description of what you
would have done, and why.

### Work outcome

* Finish the task. If the task is too big to do within the available time please do as
much as possible and describe the missing steps in text, pseudo code etc.
* The log files, written as they are now. Two log-files, one with numbers going from 50 down
to something – when the component is stopped without flush. One file having logs with
numbers going from 0 to 14
* A few words on what is fixed, refactored and why the code ended up looking as it does in
the end
* Finally we don't expect you to spend a whole or several days on this, but feel free to put in an effort and share something you feel proud of!
