# Welcome to Pod 4 Contribution Guide

This is a basic guide for contributing to the project.
Please follow this guide to minimize conflicts when setting up 
the development environment, opening new issues and pull requests.

## New Contributor Guide

For an overview of the project, read the [README](/README.md).

Here is a list of tools you will have to setup to contribute:

- [Unity Hub](https://unity.com/download#how-get-started): Get Unity Hub to easily manage the project.
- [Unity Editor](https://unity.com/releases/editor/archive): Find the editor version 2021.3.12 and install it.
- Git
    - Make sure you configure `git` with your name and email, this will be used to identify your commits for pull requests.

## Workflow

> This section assumes that you have cloned the repository
> knows the basic of `git`

1. Create a new branch with a branch name that follows this pattern `[a-zA-Z0-9]+(?:[a-zA-Z0-9])*`
    - Or names that are like this `abc`, `abc-def`.
2. Commits should have the start with the action, such as `add`, `update`, `remove` then follow by `: description`
    - For example: `add: battle scenes in the jail room`
    - **Note: be percise when adding files and making commits. Do not add files that are not related to the commit.**
3. Push your changes and create a new pull request. You will need to assign at least two other developers to review your commits and approve them before merging the branch to the main branch.


