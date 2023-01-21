﻿using System.IO;
using System.Reflection;
using System.Resources;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Autofac;
using MusicBeePlugin.GUI.ViewModels;

namespace MusicBeePlugin.GUI.Views
{
    // todo сделать как другие компоненты, через наследование от context menu
    public static class InboxRelocateContextMenu
    {
        public static ContextMenu LoadInboxRelocateContextMenu(this IContainer container)
        {
            var resourceDictionary = LoadDictionary();

            var contextMenu = (ContextMenu)resourceDictionary[nameof(InboxRelocateContextMenu)];

            contextMenu.DataContext = container.Resolve<InboxRelocateContextMenuVM>();

            return contextMenu;
        }

        private static ResourceDictionary LoadDictionary()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName =
                $"{nameof(MusicBeePlugin)}.{nameof(GUI)}.{nameof(Views)}.{nameof(InboxRelocateContextMenu)}.xaml";

            using var stream = assembly.GetManifestResourceStream(resourceName);

            if (stream is null)
            {
                throw new MissingManifestResourceException($"Resource with name \"{resourceName}\" not found.");
            }

            using var streamReader = new StreamReader(stream);

            var rawXaml = streamReader.ReadToEnd();
            return (ResourceDictionary)XamlReader.Parse(rawXaml);
        }
    }
}