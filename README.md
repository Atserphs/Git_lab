# Introduction
This repository is for storing and documenting the lab report of VB.NET. It includes:
1. VS_studio_lab - It stores console app of different lab.
2. Readme.md - This is a report file for all project. It shows detail explanation and include screenshot image of lab practical. 

## Table of Contents
- [Lab1 - Git Installation, Setup, and Basic Commands](#lab1)
- [Lab2 - Building Console Application](#lab2)


## Lab1 - Git Installation, Setup, and Basic Commands
   ###GIT 
   Git was created by Linus Torvalds in 2005 (Creator of Linux OS). It is a distributed version control 
   system used for keeping track of changes, managing multiple versions of code and collaborating 
   seamlessly across teams. It allows developers to work on their own local copies of a project, while 
   still enabling them to push changes to a shared repository.  <br>
   Git helps to manage and track changes in code by keeping log of commits, branching, showing 
   changes made, and etc. The key features of GIT are, <br>
   - Version Tracking: GIT follows all adjustments done in one record, letting you revert to old 
   releases without trouble. 
   - Collaboration: Different programmers can work on a similar task at the same time without 
   clash. 
   - Branching: You have the option to create distinct branches for new attributes, bug repairs 
   or tests. 
   - Distributed System: Every programmer has an entire version of the project implying that 
   it is decentralized software. 
   - Log of Commits: With this feature, GIT maintains an account of all commit actions 
   (changes), which makes understanding how a project has evolved over time much easier. 
   Basic command of GIT: 
   1. Setup and Configuration
      1. git config –global user.name “user_name” : Sets your name in git. 
      2. git config –global user.email “user@gmail.com” : Sets your email in git. 
   2. Repository Management 
      1. git init : Initializes a new git repository. 
      2. git log : Shows commit details eg.(commit_id, author, date, branch) 
      3. git clone <repository_url> : Clones an existing repository. 
   3. Working with Changes 
      1. git add <file> : Stages a specific file for commit. but if use dot. 
      2. git add . : Stages all changes in stage area. 
      3. git commit -m “commit _message” : Commits staged changes with a message. 
   4. Branching and Merging 
      1. git branch : List all branches. 
      2. git branch <branch_name> : Create a new branch. 
      3. git checkout <branch_name>: Switches to a specified branch also adding.all 
         changes of working branch into staging area of destination branch. 
      4. git switch <branch_name> : Just switches to specified branch. 
      5. dir : Show all directories available in working branch. 
      6. git merge <branch> : Merges a branch into the current branch. 
   5. Viewing Changes and Logs 
      1. git status : Shows the status of changes. 
      2. git log : Displays commit history. 
      3. git diff : Show difference between files. 
   6. Remote Repository 
      1. git remote add origin “repository_url” : Adds a remote repository. 
      2. git push origin -u <branch_name> : First time push branch. 
      3. git push origin <branch_name> : Pushing changes to remote repository. 
      4. git pull origin <branch_name> : Pulls changes from a remote repository. 
   
   
   ### GitHub: 
   GitHub is a web-based platform that uses Git, a version control system, to help developers manage 
   and track changes in their code. GitHub itself provides access control, bug tracking, software 
   feature requests, task management, continuous integration, and wikis for project. Here are some 
   key features of GitHub, 
   - Code Review: Inline commenting and feedback system for improving code quality 
   collaboratively. 
   - Issues Tracking: Organize and track tasks, bugs, and features requests with labels, 
   milestones, and assignees. 
   - Pull Request: A structured way for developers to propose, discuss and review changes 
   before me arranging them. 
   - Actions: Automate workflows like testing, or deployment. 
   - Projects: A Kanban-style project board to visualize workflows and task progress. 
   - Wiki: Serves as a collaborative space for documentation. It’s especially useful for projects 
   that require comprehensive instructions, guidelines, or other important information. 
   - Security: It have Dependabot and Code Scanning to ensure the no security compromised. 
      1. Dependabot: Automatically updates dependencies to reduce security risks. 
      2. Code Scanning: Detect vulnerabilities and potential issues in codebases. 
   - Insights: Provides valuable analytics about your repository to track activity and improve 
   project management 
   - Code Hosting and Sharing: Share codes in repository. Also host static websites directly 
   from repository.

## Lab2 - Building Console Application
