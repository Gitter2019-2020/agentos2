---
name: Reviewer

on:
  pull_request:
    types: [opened, ready_for_review]
---
Review this pull request.

Check:
- correctness
- security
- coding standards
- buildability

Ensure that all checks pass before approving the pull request.