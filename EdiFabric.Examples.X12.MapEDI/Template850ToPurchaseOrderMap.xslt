<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
  <xsl:output method="xml" indent="yes"/>

  <xsl:template match="/">
    <xsl:apply-templates select="/TS850" />
  </xsl:template>
  <xsl:template match="/TS850">
    <PurchaseOrder>
      <xsl:if test="BEG/PurchaseOrderNumber_03">
        <RefNumber>
          <xsl:value-of select="BEG/PurchaseOrderNumber_03/text()" />
        </RefNumber>
      </xsl:if>
      <xsl:if test="BEG/Date_05">
        <Date>
          <xsl:value-of select="concat(substring(BEG/Date_05/text(),1,4),'-',substring(BEG/Date_05/text(),5,2),'-',substring(BEG/Date_05/text(),7,2))" />
        </Date>
      </xsl:if>
      <xsl:for-each select="N1Loop">
        <xsl:for-each select="Loop_N1_850">
          <xsl:for-each select="N3">
            <xsl:for-each select="N3">
              <xsl:variable name="v1" select="string(../../N1/EntityIdentifierCode_01/text())='ST'" />
              <Customer>
                <xsl:if test="string($v1)='true'">
                  <Name>
                    <xsl:value-of select="../../N1/Name_02/text()" />
                  </Name>
                </xsl:if>
                <xsl:if test="string($v1)='true'">
                  <RefNumber>
                    <xsl:value-of select="../../N1/IdentificationCode_04/text()" />
                  </RefNumber>
                </xsl:if>
                <xsl:if test="string($v1)='true'">
                  <AddressLine>
                    <xsl:value-of select="AddressInformation_01/text()" />
                  </AddressLine>
                </xsl:if>
                <xsl:if test="string($v1)='true'">
                  <City>
                    <xsl:value-of select="../../N4/N4/CityName_01/text()" />
                  </City>
                </xsl:if>
                <xsl:if test="string($v1)='true'">
                  <State>
                    <xsl:value-of select="../../N4/N4/StateorProvinceCode_02/text()" />
                  </State>
                </xsl:if>
                <xsl:if test="string($v1)='true'">
                  <PostCode>
                    <xsl:value-of select="../../N4/N4/PostalCode_03/text()" />
                  </PostCode>
                </xsl:if>
              </Customer>
            </xsl:for-each>
          </xsl:for-each>
        </xsl:for-each>
      </xsl:for-each>
      <OrderLines>
        <xsl:for-each select="PO1Loop">
          <xsl:for-each select="Loop_PO1_850">
            <OrderLine>
              <xsl:if test="PO1/AssignedIdentification_01">
                <LineNumber>
                  <xsl:value-of select="PO1/AssignedIdentification_01/text()" />
                </LineNumber>
              </xsl:if>
              <xsl:if test="PO1/ProductServiceID_07">
                <UPCNumber>
                  <xsl:value-of select="PO1/ProductServiceID_07/text()" />
                </UPCNumber>
              </xsl:if>
              <xsl:if test="PO1/QuantityOrdered_02">
                <Quantity>
                  <xsl:value-of select="PO1/QuantityOrdered_02/text()" />
                </Quantity>
              </xsl:if>
              <xsl:if test="PO1/UnitPrice_04">
                <Price>
                  <xsl:value-of select="PO1/UnitPrice_04/text()" />
                </Price>
              </xsl:if>
              <xsl:if test="PO1/UnitorBasisforMeasurementCode_03">
                <UOM>
                  <xsl:value-of select="PO1/UnitorBasisforMeasurementCode_03/text()" />
                </UOM>
              </xsl:if>
              
            </OrderLine>
          </xsl:for-each>
        </xsl:for-each>
      </OrderLines>
    </PurchaseOrder>
  </xsl:template>
</xsl:stylesheet>
