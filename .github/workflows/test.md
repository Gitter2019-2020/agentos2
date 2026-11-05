---
on:
  issues:
    types: [opened]

permissions:
  issues: read
  contents: read
  pull-requests: read
  copilot-requests: write

# tools:
#   github:
#     toolsets: [default]
mcp-servers:
  github-aks:
    url: "https://github-mcp.ypto-sdcoe.com/"
    allowed: ["*"]
    headers:
      Authorization: "Bearer ${{ secrets.TEST }}"

safe-outputs: 
  add-comment: 
    max: 1
---
Create an issue titled "MCP smoke test".
The issue body should contain the text "This is a test for the MCP server github-aks."