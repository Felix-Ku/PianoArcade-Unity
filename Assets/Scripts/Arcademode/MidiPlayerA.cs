using System;
using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;

public class MidiPlayerA : MonoBehaviour 
{
	public GameController Gamecontroller;

	// Global variable for storing notes of MIDI song

	[Header("Properties")]
	public float GlobalSpeed = 1;

	public MidiSongg[] MIDISongs;

	public MidiNote[] MidiNotes;
 
	public UnityEvent OnPlayTrack { get; set; }

	MidiFileInspector _midi;

	string _path;
	string[] _keyIndex;
	int _noteIndex = 0;
	int _midiIndex;
	float _timer = 0;
	bool _preset = false;

	void Start ()
	{
	
		
		_midiIndex = 0;

		if (!_preset)
			PlayCurrentMIDI();
		else
		{
#if UNITY_EDITOR
			_path = string.Format("{0}/MIDI/{1}.mid", Application.streamingAssetsPath, MIDISongs[0].MIDIFile.name);
			
#else
			_path = string.Format("{0}/MIDI/{1}.mid", Application.streamingAssetsPath, MIDISongs[0].SongFileName);

#endif
			_midi = new MidiFileInspector(_path);
			
			OnPlayTrack.Invoke();
		}

        
        
	}

	void Update ()
	{

	}

	

	void PlayCurrentMIDI()
	{
		_timer = 0;

#if UNITY_EDITOR
		_path = string.Format("{0}/MIDI/{1}.mid", Application.streamingAssetsPath, MIDISongs[_midiIndex].MIDIFile.name);
#else
		_path = string.Format("{0}/MIDI/{1}.mid", Application.streamingAssetsPath, MIDISongs[_midiIndex].SongFileName);
#endif
		_midi = new MidiFileInspector(_path);
		MidiNotes = _midi.GetNotes();
		_noteIndex = 0;

	}

	[ContextMenu("Preset MIDI")]
	void PresetFirstMIDI()
	{
#if UNITY_EDITOR
		_path = string.Format("{0}/MIDI/{1}.mid", Application.streamingAssetsPath, MIDISongs[0].MIDIFile.name);
#else
		_path = string.Format("{0}/MIDI/{1}.mid", Application.streamingAssetsPath, MIDISongs[0].SongFileName);
#endif
		_midi = new MidiFileInspector(_path);
		MidiNotes = _midi.GetNotes();
		
		
		_preset = true;
	}

	[ContextMenu("Clear MIDI")]
	void ClearPresetMIDI()
	{
		MidiNotes = new MidiNote[0];
		_preset = false;
	}

#if UNITY_EDITOR
	[ContextMenu("MIDI to name")]
	public void MIDIToPlaylist()
	{
		for (int i = 0; i < MIDISongs.Length; i++)
		{
			MIDISongs[i].SongFileName = MIDISongs[i].MIDIFile.name;
		}
	}
#endif
}

[Serializable]
public class MidiSongg
{
#if UNITY_EDITOR
	public UnityEngine.Object MIDIFile;
#endif
	public string SongFileName;
	public float Speed = 1;
	[TextArea]
	public string Details;
}