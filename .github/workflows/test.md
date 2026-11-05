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
Use the MCP server named github-aks.

Do not use built-in GitHub tools.

List the available tools on github-aks.