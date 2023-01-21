using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Root.MusicBeeApi.Abstract;

namespace Root.MusicBeeApi
{
    public sealed class MusicBeeApiMemoryContainerWrapper : IMusicBeeApi
    {
        private readonly MusicBeeApiMemoryContainer _mbApi;
        
        public MusicBeeApiMemoryContainerWrapper(MusicBeeApiMemoryContainer mbApi)
        {
            _mbApi = mbApi;
        }
        
        public void MB_ReleaseString(string p1)
        {
            _mbApi.MB_ReleaseString(p1);
        }
        
        public void MB_Trace(string p1)
        {
            _mbApi.MB_Trace(p1);
        }
        
        public string Setting_GetPersistentStoragePath()
        {
            return _mbApi.Setting_GetPersistentStoragePath();
        }
        
        public string Setting_GetSkin()
        {
            return _mbApi.Setting_GetSkin();
        }
        
        public int Setting_GetSkinElementColour(SkinElement element, ElementState state, ElementComponent component)
        {
            return _mbApi.Setting_GetSkinElementColour(element, state, component);
        }
        
        public bool Setting_IsWindowBordersSkinned()
        {
            return _mbApi.Setting_IsWindowBordersSkinned();
        }
        
        public string Library_GetFileProperty(string sourceFileUrl, FilePropertyType type)
        {
            return _mbApi.Library_GetFileProperty(sourceFileUrl, type);
        }
        
        public string Library_GetFileTag(string sourceFileUrl, MetaDataType field)
        {
            return _mbApi.Library_GetFileTag(sourceFileUrl, field);
        }
        
        public bool Library_SetFileTag(string sourceFileUrl, MetaDataType field, string value)
        {
            return _mbApi.Library_SetFileTag(sourceFileUrl, field, value);
        }
        
        public bool Library_CommitTagsToFile(string sourceFileUrl)
        {
            return _mbApi.Library_CommitTagsToFile(sourceFileUrl);
        }
        
        public string Library_GetLyrics(string sourceFileUrl, LyricsType type)
        {
            return _mbApi.Library_GetLyrics(sourceFileUrl, type);
        }
        
        public bool Library_QueryFiles(string query)
        {
            return _mbApi.Library_QueryFiles(query);
        }
        
        public string Library_QueryGetNextFile()
        {
            return _mbApi.Library_QueryGetNextFile();
        }
        
        public int Player_GetPosition()
        {
            return _mbApi.Player_GetPosition();
        }
        
        public bool Player_SetPosition(int position)
        {
            return _mbApi.Player_SetPosition(position);
        }
        
        public PlayState Player_GetPlayState()
        {
            return _mbApi.Player_GetPlayState();
        }
        
        public bool Player_PlayPause()
        {
            return _mbApi.Player_PlayPause();
        }
        
        public bool Player_Stop()
        {
            return _mbApi.Player_Stop();
        }
        
        public bool Player_StopAfterCurrent()
        {
            return _mbApi.Player_StopAfterCurrent();
        }
        
        public bool Player_PlayPreviousTrack()
        {
            return _mbApi.Player_PlayPreviousTrack();
        }
        
        public bool Player_PlayNextTrack()
        {
            return _mbApi.Player_PlayNextTrack();
        }
        
        public bool Player_StartAutoDj()
        {
            return _mbApi.Player_StartAutoDj();
        }
        
        public bool Player_EndAutoDj()
        {
            return _mbApi.Player_EndAutoDj();
        }
        
        public float Player_GetVolume()
        {
            return _mbApi.Player_GetVolume();
        }
        
        public bool Player_SetVolume(float volume)
        {
            return _mbApi.Player_SetVolume(volume);
        }
        
        public bool Player_GetMute()
        {
            return _mbApi.Player_GetMute();
        }
        
        public bool Player_SetMute(bool mute)
        {
            return _mbApi.Player_SetMute(mute);
        }
        
        public bool Player_GetShuffle()
        {
            return _mbApi.Player_GetShuffle();
        }
        
        public bool Player_SetShuffle(bool shuffle)
        {
            return _mbApi.Player_SetShuffle(shuffle);
        }
        
        public RepeatMode Player_GetRepeat()
        {
            return _mbApi.Player_GetRepeat();
        }
        
        public bool Player_SetRepeat(RepeatMode repeat)
        {
            return _mbApi.Player_SetRepeat(repeat);
        }
        
        public bool Player_GetEqualiserEnabled()
        {
            return _mbApi.Player_GetEqualiserEnabled();
        }
        
        public bool Player_SetEqualiserEnabled(bool enabled)
        {
            return _mbApi.Player_SetEqualiserEnabled(enabled);
        }
        
        public bool Player_GetDspEnabled()
        {
            return _mbApi.Player_GetDspEnabled();
        }
        
        public bool Player_SetDspEnabled(bool enabled)
        {
            return _mbApi.Player_SetDspEnabled(enabled);
        }
        
        public bool Player_GetScrobbleEnabled()
        {
            return _mbApi.Player_GetScrobbleEnabled();
        }
        
        public bool Player_SetScrobbleEnabled(bool enabled)
        {
            return _mbApi.Player_SetScrobbleEnabled(enabled);
        }
        
        public string NowPlaying_GetFileUrl()
        {
            return _mbApi.NowPlaying_GetFileUrl();
        }
        
        public int NowPlaying_GetDuration()
        {
            return _mbApi.NowPlaying_GetDuration();
        }
        
        public string NowPlaying_GetFileProperty(FilePropertyType type)
        {
            return _mbApi.NowPlaying_GetFileProperty(type);
        }
        
        public string NowPlaying_GetFileTag(MetaDataType field)
        {
            return _mbApi.NowPlaying_GetFileTag(field);
        }
        
        public string NowPlaying_GetLyrics()
        {
            return _mbApi.NowPlaying_GetLyrics();
        }
        
        public string NowPlaying_GetArtwork()
        {
            return _mbApi.NowPlaying_GetArtwork();
        }
        
        public bool NowPlayingList_Clear()
        {
            return _mbApi.NowPlayingList_Clear();
        }
        
        public bool NowPlayingList_QueryFiles(string query)
        {
            return _mbApi.NowPlayingList_QueryFiles(query);
        }
        
        public string NowPlayingList_QueryGetNextFile()
        {
            return _mbApi.NowPlayingList_QueryGetNextFile();
        }
        
        public bool NowPlayingList_PlayNow(string sourceFileUrl)
        {
            return _mbApi.NowPlayingList_PlayNow(sourceFileUrl);
        }
        
        public bool NowPlayingList_QueueNext(string sourceFileUrl)
        {
            return _mbApi.NowPlayingList_QueueNext(sourceFileUrl);
        }
        
        public bool NowPlayingList_QueueLast(string sourceFileUrl)
        {
            return _mbApi.NowPlayingList_QueueLast(sourceFileUrl);
        }
        
        public bool NowPlayingList_PlayLibraryShuffled()
        {
            return _mbApi.NowPlayingList_PlayLibraryShuffled();
        }
        
        public bool Playlist_QueryPlaylists()
        {
            return _mbApi.Playlist_QueryPlaylists();
        }
        
        public string Playlist_QueryGetNextPlaylist()
        {
            return _mbApi.Playlist_QueryGetNextPlaylist();
        }
        
        public PlaylistFormat Playlist_GetType(string playlistUrl)
        {
            return _mbApi.Playlist_GetType(playlistUrl);
        }
        
        public bool Playlist_QueryFiles(string playlistUrl)
        {
            return _mbApi.Playlist_QueryFiles(playlistUrl);
        }
        
        public string Playlist_QueryGetNextFile()
        {
            return _mbApi.Playlist_QueryGetNextFile();
        }
        
        public IntPtr MB_GetWindowHandle()
        {
            return _mbApi.MB_GetWindowHandle();
        }
        
        public void MB_RefreshPanels()
        {
            _mbApi.MB_RefreshPanels();
        }
        
        public void MB_SendNotification(CallbackType type)
        {
            _mbApi.MB_SendNotification(type);
        }
        
        public ToolStripItem MB_AddMenuItem(string menuPath, string hotkeyDescription, EventHandler handler)
        {
            return _mbApi.MB_AddMenuItem(menuPath, hotkeyDescription, handler);
        }
        
        public string Setting_GetFieldName(MetaDataType field)
        {
            return _mbApi.Setting_GetFieldName(field);
        }
        
        public void MB_CreateBackgroundTask(ThreadStart taskCallback, Form owner)
        {
            _mbApi.MB_CreateBackgroundTask(taskCallback, owner);
        }
        
        public void MB_SetBackgroundTaskMessage(string message)
        {
            _mbApi.MB_SetBackgroundTaskMessage(message);
        }
        
        public void MB_RegisterCommand(string command, EventHandler handler)
        {
            _mbApi.MB_RegisterCommand(command, handler);
        }
        
        public Font Setting_GetDefaultFont()
        {
            return _mbApi.Setting_GetDefaultFont();
        }
        
        public bool Player_GetShowTimeRemaining()
        {
            return _mbApi.Player_GetShowTimeRemaining();
        }
        
        public int NowPlayingList_GetCurrentIndex()
        {
            return _mbApi.NowPlayingList_GetCurrentIndex();
        }
        
        public string NowPlayingList_GetListFileUrl(int index)
        {
            return _mbApi.NowPlayingList_GetListFileUrl(index);
        }
        
        public string NowPlayingList_GetFileProperty(int index, FilePropertyType type)
        {
            return _mbApi.NowPlayingList_GetFileProperty(index, type);
        }
        
        public string NowPlayingList_GetFileTag(int index, MetaDataType field)
        {
            return _mbApi.NowPlayingList_GetFileTag(index, field);
        }
        
        public int NowPlaying_GetSpectrumData(float[] fftData)
        {
            return _mbApi.NowPlaying_GetSpectrumData(fftData);
        }
        
        public bool NowPlaying_GetSoundGraph(float[] graphData)
        {
            return _mbApi.NowPlaying_GetSoundGraph(graphData);
        }
        
        public Rectangle MB_GetPanelBounds(PluginPanelDock dock)
        {
            return _mbApi.MB_GetPanelBounds(dock);
        }
        
        public Control MB_AddPanel(Control panel, PluginPanelDock dock)
        {
            return _mbApi.MB_AddPanel(panel, dock);
        }
        
        public void MB_RemovePanel(Control panel)
        {
            _mbApi.MB_RemovePanel(panel);
        }
        
        public string MB_GetLocalisation(string id, string defaultText)
        {
            return _mbApi.MB_GetLocalisation(id, defaultText);
        }
        
        public bool NowPlayingList_IsAnyPriorTracks()
        {
            return _mbApi.NowPlayingList_IsAnyPriorTracks();
        }
        
        public bool Player_ShowEqualiser()
        {
            return _mbApi.Player_ShowEqualiser();
        }
        
        public bool Player_GetAutoDjEnabled()
        {
            return _mbApi.Player_GetAutoDjEnabled();
        }
        
        public bool Player_GetStopAfterCurrentEnabled()
        {
            return _mbApi.Player_GetStopAfterCurrentEnabled();
        }
        
        public bool Player_GetCrossfade()
        {
            return _mbApi.Player_GetCrossfade();
        }
        
        public bool Player_SetCrossfade(bool crossfade)
        {
            return _mbApi.Player_SetCrossfade(crossfade);
        }
        
        public ReplayGainMode Player_GetReplayGainMode()
        {
            return _mbApi.Player_GetReplayGainMode();
        }
        
        public bool Player_SetReplayGainMode(ReplayGainMode mode)
        {
            return _mbApi.Player_SetReplayGainMode(mode);
        }
        
        public int Player_QueueRandomTracks(int count)
        {
            return _mbApi.Player_QueueRandomTracks(count);
        }
        
        public DataType Setting_GetDataType(MetaDataType field)
        {
            return _mbApi.Setting_GetDataType(field);
        }
        
        public int NowPlayingList_GetNextIndex(int offset)
        {
            return _mbApi.NowPlayingList_GetNextIndex(offset);
        }
        
        public string NowPlaying_GetArtistPicture(int fadingPercent)
        {
            return _mbApi.NowPlaying_GetArtistPicture(fadingPercent);
        }
        
        public string NowPlaying_GetDownloadedArtwork()
        {
            return _mbApi.NowPlaying_GetDownloadedArtwork();
        }
        
        public bool MB_ShowNowPlayingAssistant()
        {
            return _mbApi.MB_ShowNowPlayingAssistant();
        }
        
        public string NowPlaying_GetDownloadedLyrics()
        {
            return _mbApi.NowPlaying_GetDownloadedLyrics();
        }
        
        public bool Player_GetShowRatingTrack()
        {
            return _mbApi.Player_GetShowRatingTrack();
        }
        
        public bool Player_GetShowRatingLove()
        {
            return _mbApi.Player_GetShowRatingLove();
        }
        
        public void MB_CreateParameterisedBackgroundTask(ParameterizedThreadStart taskCallback, object parameters, Form owner)
        {
            _mbApi.MB_CreateParameterisedBackgroundTask(taskCallback, parameters, owner);
        }
        
        public string Setting_GetLastFmUserId()
        {
            return _mbApi.Setting_GetLastFmUserId();
        }
        
        public string Playlist_GetName(string playlistUrl)
        {
            return _mbApi.Playlist_GetName(playlistUrl);
        }
        
        public string Playlist_CreatePlaylist(string folderName, string playlistName, string[] filenames)
        {
            return _mbApi.Playlist_CreatePlaylist(folderName, playlistName, filenames);
        }
        
        public bool Playlist_SetFiles(string playlistUrl, string[] filenames)
        {
            return _mbApi.Playlist_SetFiles(playlistUrl, filenames);
        }
        
        public string Library_QuerySimilarArtists(string artistName, double minimumArtistSimilarityRating)
        {
            return _mbApi.Library_QuerySimilarArtists(artistName, minimumArtistSimilarityRating);
        }
        
        public bool Library_QueryLookupTable(string keyTags, string valueTags, string query)
        {
            return _mbApi.Library_QueryLookupTable(keyTags, valueTags, query);
        }
        
        public string Library_QueryGetLookupTableValue(string key)
        {
            return _mbApi.Library_QueryGetLookupTableValue(key);
        }
        
        public bool NowPlayingList_QueueFilesNext(string[] sourceFileUrl)
        {
            return _mbApi.NowPlayingList_QueueFilesNext(sourceFileUrl);
        }
        
        public bool NowPlayingList_QueueFilesLast(string[] sourceFileUrl)
        {
            return _mbApi.NowPlayingList_QueueFilesLast(sourceFileUrl);
        }
        
        public string Setting_GetWebProxy()
        {
            return _mbApi.Setting_GetWebProxy();
        }
        
        public bool NowPlayingList_RemoveAt(int index)
        {
            return _mbApi.NowPlayingList_RemoveAt(index);
        }
        
        public bool Playlist_RemoveAt(string playlistUrl, int index)
        {
            return _mbApi.Playlist_RemoveAt(playlistUrl, index);
        }
        
        public bool MB_SetPanelScrollableArea(Control panel, Size scrollArea, bool alwaysShowScrollBar)
        {
            return _mbApi.MB_SetPanelScrollableArea(panel, scrollArea, alwaysShowScrollBar);
        }
        
        public bool MB_InvokeCommand(Command command, object parameter)
        {
            return _mbApi.MB_InvokeCommand(command, parameter);
        }
        
        public bool MB_OpenFilterInTab(MetaDataType field1, ComparisonType comparison1, string value1, MetaDataType field2, ComparisonType comparison2, string value2)
        {
            return _mbApi.MB_OpenFilterInTab(field1, comparison1, value1, field2, comparison2, value2);
        }
        
        public bool MB_SetWindowSize(int width, int height)
        {
            return _mbApi.MB_SetWindowSize(width, height);
        }
        
        public string Library_GetArtistPicture(string artistName, int fadingPercent, int fadingColor)
        {
            return _mbApi.Library_GetArtistPicture(artistName, fadingPercent, fadingColor);
        }
        
        public string Pending_GetFileUrl()
        {
            return _mbApi.Pending_GetFileUrl();
        }
        
        public string Pending_GetFileProperty(FilePropertyType field)
        {
            return _mbApi.Pending_GetFileProperty(field);
        }
        
        public string Pending_GetFileTag(MetaDataType field)
        {
            return _mbApi.Pending_GetFileTag(field);
        }
        
        public bool Player_GetButtonEnabled(PlayButtonType button)
        {
            return _mbApi.Player_GetButtonEnabled(button);
        }
        
        public bool NowPlayingList_MoveFiles(int[] fromIndices, int toIndex)
        {
            return _mbApi.NowPlayingList_MoveFiles(fromIndices, toIndex);
        }
        
        public string Library_GetArtworkUrl(string sourceFileUrl, int index)
        {
            return _mbApi.Library_GetArtworkUrl(sourceFileUrl, index);
        }
        
        public string Library_GetArtistPictureThumb(string artistName)
        {
            return _mbApi.Library_GetArtistPictureThumb(artistName);
        }
        
        public string NowPlaying_GetArtworkUrl()
        {
            return _mbApi.NowPlaying_GetArtworkUrl();
        }
        
        public string NowPlaying_GetDownloadedArtworkUrl()
        {
            return _mbApi.NowPlaying_GetDownloadedArtworkUrl();
        }
        
        public string NowPlaying_GetArtistPictureThumb()
        {
            return _mbApi.NowPlaying_GetArtistPictureThumb();
        }
        
        public bool Playlist_IsInList(string playlistUrl, string filename)
        {
            return _mbApi.Playlist_IsInList(playlistUrl, filename);
        }
        
        public bool Library_GetArtistPictureUrls(string artistName, bool localOnly, out string[] urls)
        {
            return _mbApi.Library_GetArtistPictureUrls(artistName, localOnly, out urls);
        }
        
        public bool NowPlaying_GetArtistPictureUrls(bool localOnly, out string[] urls)
        {
            return _mbApi.NowPlaying_GetArtistPictureUrls(localOnly, out urls);
        }
        
        public bool Playlist_AppendFiles(string playlistUrl, string[] filenames)
        {
            return _mbApi.Playlist_AppendFiles(playlistUrl, filenames);
        }
        
        public string Sync_FileStart(string filename)
        {
            return _mbApi.Sync_FileStart(filename);
        }
        
        public void Sync_FileEnd(string filename, bool success, string errorMessage)
        {
            _mbApi.Sync_FileEnd(filename, success, errorMessage);
        }
        
        public bool Library_QueryFilesEx(string query, out string[]? files)
        {
            return _mbApi.Library_QueryFilesEx(query, out files);
        }
        
        public bool NowPlayingList_QueryFilesEx(string query, out string[]? files)
        {
            return _mbApi.NowPlayingList_QueryFilesEx(query, out files);
        }
        
        public bool Playlist_QueryFilesEx(string playlistUrl, out string[] filenames)
        {
            return _mbApi.Playlist_QueryFilesEx(playlistUrl, out filenames);
        }
        
        public bool Playlist_MoveFiles(string playlistUrl, int[] fromIndices, int toIndex)
        {
            return _mbApi.Playlist_MoveFiles(playlistUrl, fromIndices, toIndex);
        }
        
        public bool Playlist_PlayNow(string playlistUrl)
        {
            return _mbApi.Playlist_PlayNow(playlistUrl);
        }
        
        public bool NowPlaying_IsSoundtrack()
        {
            return _mbApi.NowPlaying_IsSoundtrack();
        }
        
        public bool NowPlaying_GetSoundtrackPictureUrls(bool localOnly, out string[] urls)
        {
            return _mbApi.NowPlaying_GetSoundtrackPictureUrls(localOnly, out urls);
        }
        
        public string Library_GetDevicePersistentId(string sourceFileUrl, DeviceIdType idType)
        {
            return _mbApi.Library_GetDevicePersistentId(sourceFileUrl, idType);
        }
        
        public bool Library_SetDevicePersistentId(string sourceFileUrl, DeviceIdType idType, string value)
        {
            return _mbApi.Library_SetDevicePersistentId(sourceFileUrl, idType, value);
        }
        
        public bool Library_FindDevicePersistentId(DeviceIdType idType, string[] ids, out string[] values)
        {
            return _mbApi.Library_FindDevicePersistentId(idType, ids, out values);
        }
        
        public bool Setting_GetValue(SettingId settingId, out object value)
        {
            return _mbApi.Setting_GetValue(settingId, out value);
        }
        
        public string Library_AddFileToLibrary(string sourceFileUrl, LibraryCategory category)
        {
            return _mbApi.Library_AddFileToLibrary(sourceFileUrl, category);
        }
        
        public bool Playlist_DeletePlaylist(string playlistUrl)
        {
            return _mbApi.Playlist_DeletePlaylist(playlistUrl);
        }
        
        public bool Library_GetSyncDelta(string[] cachedFiles, DateTime updatedSince, LibraryCategory categories, out string[] newFiles, out string[] updatedFiles, out string[] deletedFiles)
        {
            return _mbApi.Library_GetSyncDelta(cachedFiles, updatedSince, categories, out newFiles, out updatedFiles, out deletedFiles);
        }
        
        public bool Library_GetFileTags(string sourceFileUrl, MetaDataType[] fields, out string[] results)
        {
            return _mbApi.Library_GetFileTags(sourceFileUrl, fields, out results);
        }
        
        public bool NowPlaying_GetFileTags(MetaDataType[] fields, out string[] results)
        {
            return _mbApi.NowPlaying_GetFileTags(fields, out results);
        }
        
        public bool NowPlayingList_GetFileTags(int index, MetaDataType[] fields, out string[] results)
        {
            return _mbApi.NowPlayingList_GetFileTags(index, fields, out results);
        }
        
        public bool MB_AddTreeNode(string treePath, string name, Bitmap icon, EventHandler openHandler, EventHandler closeHandler)
        {
            return _mbApi.MB_AddTreeNode(treePath, name, icon, openHandler, closeHandler);
        }
        
        public bool MB_DownloadFile(string url, DownloadTarget target, string targetFolder, bool cancelDownload)
        {
            return _mbApi.MB_DownloadFile(url, target, targetFolder, cancelDownload);
        }
        
        public string Setting_GetFileConvertCommandLine(FileCodec codec, EncodeQuality encodeQuality)
        {
            return _mbApi.Setting_GetFileConvertCommandLine(codec, encodeQuality);
        }
        
        public int Player_OpenStreamHandle(string url, bool useMusicBeeSettings, bool enableDsp, ReplayGainMode gainType)
        {
            return _mbApi.Player_OpenStreamHandle(url, useMusicBeeSettings, enableDsp, gainType);
        }
        
        public bool Player_UpdatePlayStatistics(string url, PlayStatisticType countType, bool disableScrobble)
        {
            return _mbApi.Player_UpdatePlayStatistics(url, countType, disableScrobble);
        }
        
        public bool Library_GetArtworkEx(string sourceFileUrl, int index, bool retrievePictureData, out PictureLocations pictureLocations, out string pictureUrl, out byte[] imageData)
        {
            return _mbApi.Library_GetArtworkEx(sourceFileUrl, index, retrievePictureData, out pictureLocations, out pictureUrl, out imageData);
        }
        
        public bool Library_SetArtworkEx(string sourceFileUrl, int index, byte[] imageData)
        {
            return _mbApi.Library_SetArtworkEx(sourceFileUrl, index, imageData);
        }
        
        public bool MB_GetVisualiserInformation(out string[] visualiserNames, out string defaultVisualiserName, out WindowState defaultState, out WindowState currentState)
        {
            return _mbApi.MB_GetVisualiserInformation(out visualiserNames, out defaultVisualiserName, out defaultState, out currentState);
        }
        
        public bool MB_ShowVisualiser(string visualiserName, WindowState state)
        {
            return _mbApi.MB_ShowVisualiser(visualiserName, state);
        }
        
        public bool MB_GetPluginViewInformation(string pluginFilename, out string[] viewNames, out string defaultViewName, out WindowState defaultState, out WindowState currentState)
        {
            return _mbApi.MB_GetPluginViewInformation(pluginFilename, out viewNames, out defaultViewName, out defaultState, out currentState);
        }
        
        public bool MB_ShowPluginView(string pluginFilename, string viewName, WindowState state)
        {
            return _mbApi.MB_ShowPluginView(pluginFilename, viewName, state);
        }
        
        public bool Player_GetOutputDevices(out string[] deviceNames, out string activeDeviceName)
        {
            return _mbApi.Player_GetOutputDevices(out deviceNames, out activeDeviceName);
        }
        
        public bool Player_SetOutputDevice(string deviceName)
        {
            return _mbApi.Player_SetOutputDevice(deviceName);
        }
        
        public bool MB_UninstallPlugin(string pluginFilename, string password)
        {
            return _mbApi.MB_UninstallPlugin(pluginFilename, password);
        }
        
        public bool Player_PlayPreviousAlbum()
        {
            return _mbApi.Player_PlayPreviousAlbum();
        }
        
        public bool Player_PlayNextAlbum()
        {
            return _mbApi.Player_PlayNextAlbum();
        }
        
        public bool Podcasts_QuerySubscriptions(string query, out string[] ids)
        {
            return _mbApi.Podcasts_QuerySubscriptions(query, out ids);
        }
        
        public bool Podcasts_GetSubscription(string id, out string[] subscription)
        {
            return _mbApi.Podcasts_GetSubscription(id, out subscription);
        }
        
        public bool Podcasts_GetSubscriptionArtwork(string id, int index, out byte[] imageData)
        {
            return _mbApi.Podcasts_GetSubscriptionArtwork(id, index, out imageData);
        }
        
        public bool Podcasts_GetSubscriptionEpisodes(string id, out string[] urls)
        {
            return _mbApi.Podcasts_GetSubscriptionEpisodes(id, out urls);
        }
        
        public bool Podcasts_GetSubscriptionEpisode(string id, int index, out string[] episode)
        {
            return _mbApi.Podcasts_GetSubscriptionEpisode(id, index, out episode);
        }
        
        public bool NowPlaying_GetSoundGraphEx(float[] graphData, float[] peakData)
        {
            return _mbApi.NowPlaying_GetSoundGraphEx(graphData, peakData);
        }
        
        public string Sync_FileDeleteStart(string filename)
        {
            return _mbApi.Sync_FileDeleteStart(filename);
        }
        
        public void Sync_FileDeleteEnd(string filename, bool success, string errorMessage)
        {
            _mbApi.Sync_FileDeleteEnd(filename, success, errorMessage);
        }
        
    }
}
