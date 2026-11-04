---
on:
  issues:
    types: [opened]

permissions:
  issues: read
  contents: read
  pull-requests: read
  copilot-requests: write

tools:
  github:
    toolsets: [default]

safe-outputs: 
  add-comment: 
    max: 1
---
When issue #${{ github.event.issue.number }} is opened:

1. Count the number of open issues in the repository.
2. Post a comment on the issue.
3. The comment must be:

"Hello from GitHub Agentic Workflows. This repository currently has X open issues."

4. Replace X with the actual number of open issues.