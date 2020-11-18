<?xml version="1.0" encoding="ISO-8859-1"?>
<xsl:stylesheet version="1.0"
xmlns:xsl="http://www.w3.org/1999/XSL/Transform"><xsl:template match="/">
  <html>
  <body>
    <h2>Staff of scientists </h2>
    <table border="1">
      <tr bgcolor="#9acd32">
        <th>Name</th>
        <th>Facultet</th>
		<th>Cafedra</th>
		<th>Degree</th>
		<th>Status</th>
      </tr>
      <xsl:for-each select="catalog/cd">
      <tr>
        <td><xsl:value-of select="Name"/></td>
        <td><xsl:value-of select="Facultet"/></td>
		<td><xsl:value-of select="Cafedra"/></td>
        <td><xsl:value-of select="Degree"/></td>
		<td><xsl:value-of select="Status"/></td>
      </tr>
      </xsl:for-each>
    </table>
  </body>
  </html>
</xsl:template></xsl:stylesheet>