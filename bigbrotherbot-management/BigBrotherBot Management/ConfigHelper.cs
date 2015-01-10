/*  Copyright (C) 2014  Vincent Cunningham

    This program is free software; you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation; either version 2 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License along
    with this program; if not, write to the Free Software Foundation, Inc.,
    51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA. */

using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace BigBrotherBot_Management
{
    internal static class ConfigHelper
    {
        public static void LoadConfig(FormMain formMain)
        {
            XDocument configFile = XDocument.Load(formMain.Config);
            IEnumerable<XElement> configList = configFile.Descendants("set");

            foreach (XElement element in configList)
            {
                if (element.Attribute("name").Value.Equals("bot_name"))
                    formMain.txtBotName.Text = element.Value;
                if (element.Attribute("name").Value.Equals("bot_prefix"))
                    formMain.txtBotPrefix.Text = element.Value;
                if (element.Attribute("name").Value.Equals("time_format"))
                    formMain.cmbTimeFormat.Text = element.Value;
                if (element.Attribute("name").Value.Equals("time_zone"))
                    formMain.cmbTimeZone.Text = element.Value;
                if (element.Attribute("name").Value.Equals("log_level"))
                    formMain.cmbLogLevel.SelectedIndex = Model.LogLevel.LogLevelDictionary[element.Value];
                if (element.Attribute("name").Value.Equals("logfile"))
                    formMain.txtLogFile.Text = element.Value;
                if (element.Attribute("name").Value.Equals("parser"))
                    formMain.cmbParser.SelectedItem = Model.Parser.ParserDictionary[element.Value];
                if (element.Attribute("name").Value.Equals("database"))
                    formMain.txtDatabase.Text = element.Value;
                if (element.Attribute("name").Value.Equals("rcon_password"))
                    formMain.txtRconPassword.Text = element.Value;
                if (element.Attribute("name").Value.Equals("port"))
                    formMain.txtServerPort.Text = element.Value;
                if (element.Attribute("name").Value.Equals("public_ip"))
                    formMain.txtPublicIp.Text = element.Value;
                if (element.Attribute("name").Value.Equals("rcon_ip"))
                    formMain.txtRconIp.Text = element.Value;
                if (element.Attribute("name").Value.Equals("delay"))
                    formMain.txtDelay.Text = element.Value;
                if (element.Attribute("name").Value.Equals("lines_per_second"))
                    formMain.txtLinesSec.Text = element.Value;
                if (element.Attribute("name").Value.Equals("punkbuster"))
                    formMain.cmbPunkbuster.SelectedIndex = element.Value.Equals("on") ? 0 : 1;
                if (element.Attribute("name").Value.Equals("game_log"))
                    formMain.txtGameLog.Text = element.Value;
                if (element.Attribute("name").Value.Equals("maxlevel"))
                    formMain.txtMaxLevel.Text = element.Value;
                if (element.Attribute("name").Value.Equals("destination"))
                    formMain.txtDestination.Text = element.Value;
                if (element.Attribute("name").Value.Equals("kicked_by"))
                    formMain.txtKickedBy.Text = element.Value;
                if (element.Attribute("name").Value.Equals("kicked"))
                    formMain.txtKicked.Text = element.Value;
                if (element.Attribute("name").Value.Equals("banned_by"))
                    formMain.txtBannedBy.Text = element.Value;
                if (element.Attribute("name").Value.Equals("banned"))
                    formMain.txtBanned.Text = element.Value;
                if (element.Attribute("name").Value.Equals("temp_banned_by"))
                    formMain.txtTempBannedBy.Text = element.Value;
                if (element.Attribute("name").Value.Equals("temp_banned"))
                    formMain.txtTempBanned.Text = element.Value;
                if (element.Attribute("name").Value.Equals("unbanned_by"))
                    formMain.txtUnbannedBy.Text = element.Value;
                if (element.Attribute("name").Value.Equals("unbanned"))
                    formMain.txtUnbanned.Text = element.Value;

                if (element.Attribute("name").Value.Equals("type"))
                {
                    string type = element.Value;
                    if (type.Equals("html"))
                    {
                        formMain.cmbType.SelectedIndex = 0;
                    }
                    else if (type.Equals("htmltable"))
                    {
                        formMain.cmbType.SelectedIndex = 1;
                    }
                    else
                    {
                        formMain.cmbType.SelectedIndex = 2;
                    }
                }

                if (element.Attribute("name").Value.Equals("channel"))
                {
                    string channel = element.Value;
                    if (channel.Equals("stable"))
                    {
                        formMain.cmbChannel.SelectedIndex = 0;
                    }
                    else if (channel.Equals("beta"))
                    {
                        formMain.cmbChannel.SelectedIndex = 1;
                    }
                    else
                    {
                        formMain.cmbChannel.SelectedIndex = 2;
                    }
                }
            }
        }

        public static XDocument SaveConfig(FormMain formMain)
        {
            var config = new XDocument(
                new XDeclaration("1.0", "UTF-8", "true"),
                new XComment("Created by BigBrotherBot Management application"),
                new XElement("configuration",
                    new XElement("settings",
                        new XAttribute("name", "b3"),
                        new XElement("set",
                            new XAttribute("name", "bot_name"), formMain.txtBotName.Text),
                        new XElement("set",
                            new XAttribute("name", "bot_prefix"), formMain.txtBotPrefix.Text),
                        new XElement("set",
                            new XAttribute("name", "time_format"), formMain.cmbTimeFormat.Text),
                        new XElement("set",
                            new XAttribute("name", "time_zone"), formMain.cmbTimeZone.Text),
                        new XElement("set",
                            new XAttribute("name", "log_level"),
                            Model.LogLevel.LogLevelDictionary.FirstOrDefault(
                                x => x.Value == formMain.cmbLogLevel.SelectedIndex).Key),
                        new XElement("set",
                            new XAttribute("name", "logfile"), formMain.txtLogFile.Text),
                        new XElement("set",
                            new XAttribute("name", "parser"),
                            Model.Parser.ParserDictionary.FirstOrDefault(
                                x => x.Value == formMain.cmbParser.SelectedItem.ToString())
                                .Key),
                        new XElement("set",
                            new XAttribute("name", "database"), formMain.txtDatabase.Text)
                        ),
                    new XElement("settings",
                        new XAttribute("name", "server"),
                        new XElement("set",
                            new XAttribute("name", "rcon_password"), formMain.txtRconPassword.Text),
                        new XElement("set",
                            new XAttribute("name", "port"), formMain.txtServerPort.Text),
                        new XElement("set",
                            new XAttribute("name", "public_ip"), formMain.txtPublicIp.Text),
                        new XElement("set",
                            new XAttribute("name", "rcon_ip"), formMain.txtRconIp.Text),
                        new XElement("set",
                            new XAttribute("name", "delay"), formMain.txtDelay.Text),
                        new XElement("set",
                            new XAttribute("name", "lines_per_second"), formMain.txtLinesSec.Text),
                        new XElement("set",
                            new XAttribute("name", "punkbuster"),
                            formMain.cmbPunkbuster.SelectedItem.ToString().ToLower()),
                        new XElement("set",
                            new XAttribute("name", "game_log"), formMain.txtGameLog.Text)
                        ),
                    new XElement("settings",
                        new XAttribute("name", "autodoc"),
                        new XElement("set",
                            new XAttribute("name", "type"), formMain.cmbType.SelectedItem.ToString()),
                        new XElement("set",
                            new XAttribute("name", "maxlevel"), formMain.txtMaxLevel.Text),
                        new XElement("set",
                            new XAttribute("name", "destination"), formMain.txtDestination.Text)
                        ),
                    new XElement("settings",
                        new XAttribute("name", "update"),
                        new XElement("set",
                            new XAttribute("name", "channel"), formMain.cmbChannel.SelectedItem.ToString())
                        ),
                    new XElement("settings",
                        new XAttribute("name", "messages"),
                        new XElement("set",
                            new XAttribute("name", "kicked_by"), formMain.txtKickedBy.Text),
                        new XElement("set",
                            new XAttribute("name", "kicked"), formMain.txtKicked.Text),
                        new XElement("set",
                            new XAttribute("name", "banned_by"), formMain.txtBannedBy.Text),
                        new XElement("set",
                            new XAttribute("name", "banned"), formMain.txtBanned.Text),
                        new XElement("set",
                            new XAttribute("name", "temp_banned_by"), formMain.txtTempBannedBy.Text),
                        new XElement("set",
                            new XAttribute("name", "temp_banned"), formMain.txtTempBanned.Text),
                        new XElement("set",
                            new XAttribute("name", "unbanned_by"), formMain.txtUnbannedBy.Text),
                        new XElement("set",
                            new XAttribute("name", "unbanned"), formMain.txtUnbanned.Text)
                        ),
                    // Default plugins
                    new XElement("settings",
                        new XAttribute("name", "plugins"),
                        new XElement("set",
                            new XAttribute("name", "external_dir"),
                            "@b3/extplugins")
                        ),
                    new XElement("plugins",
                        new XElement("plugin",
                            new XAttribute("name", "admin"),
                            new XAttribute("config", "@conf/plugin_admin.xml")
                            ),
                        new XElement("plugin",
                            new XAttribute("name", "punkbuster"),
                            new XAttribute("config", "@conf/plugin_punkbuster.xml")
                            ))));

            return config;
        }
    }
}