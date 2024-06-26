using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class NPC_Dialog : MonoBehaviour
{
    // NarrativeDialogue 스크립트에 대한 참조
    public NarrativeDialogue narrativeDialogue;

    // 사용자 정의 변수
    public string[] customSpeakerNames;
    public Color[] customSpeakerNameColors;
    public string[] customNarrativeSentences;
    public AudioClip customTypingSound;
    public TMP_Text questTMPText;
    public String customQuestDescription;
    public GameObject customQuestPanel;

    void Start()
    {

        narrativeDialogue = FindObjectOfType<NarrativeDialogue>();

        narrativeDialogue.speakerNames = customSpeakerNames;
        narrativeDialogue.speakerNameColors = customSpeakerNameColors;
        narrativeDialogue.narrativeSentences = customNarrativeSentences;
        narrativeDialogue.typingSound = customTypingSound;
        narrativeDialogue.questTMP = questTMPText;
        narrativeDialogue.questDescription = customQuestDescription;

        narrativeDialogue.questPanel = customQuestPanel;
    }
}