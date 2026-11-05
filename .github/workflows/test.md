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
# mcp-servers:
#   azure:
#     container: "mcr.microsoft.com/azure-sdk/azure-mcp"
#     version: "latest"
#     entrypointArgs:
#       - "server"
#       - "start"
#     env:
#       AZURE_TENANT_ID: "${{ secrets.AZURE_TENANT_ID }}"
#       AZURE_CLIENT_ID: "${{ secrets.AZURE_CLIENT_ID }}"
#       AZURE_CLIENT_SECRET: "${{ secrets.AZURE_CLIENT_SECRET }}"
#     allowed: ["*"]
  # github-mcp:
  #   url: "https://github-mcp.ypto-sdcoe.com/"
  #   allowed: ["*"]
  #   headers:
  #     Authorization: "Bearer ${{ secrets.TEST }}"

safe-outputs: 
  add-comment: 
    max: 1
---
Create a minimalistic asp.net core console application that converts all input text to uppercase.


<!-- ---
Create an issue titled "MCP smoke test".
The issue body should contain the text "This is a test for the MCP server github-mcp." -->