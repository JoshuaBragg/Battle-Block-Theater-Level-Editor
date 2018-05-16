f = open("BLOCKTABLE.txt", "r")
h = open("table.html", "w")

html = "<html><body><table style=\"border:1px solid black;\"><tr><th>&emsp;HEX&emsp;</th><th>&emsp;DEC&emsp;</th><th>&emsp;BLOCK NAME&emsp;</th><th>&emsp;SPRITE&emsp;</th></tr>"

for l in f.readlines():
    l = l.replace("\n", "")
    html += "<tr>"
    for s in l.split("-"):
        html += "<th>" + s + "</th>"
    html += "<th><img src=\"res/" + l.split("-")[0] + ".png\"></th>"
    html += "</tr>"

html += "</table></body></html>"

h.write(html)

f.close()
h.close()
